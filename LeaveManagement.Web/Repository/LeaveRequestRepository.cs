using AutoMapper;
using LeaveManagement.Web.Contracts;
using LeaveManagement.Web.Data;
using LeaveManagement.Web.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagement.Web.Repository
{
    public class LeaveRequestRepository : GenericRepository<LeaveRequest>, ILeaveRequestRepository
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;
        private readonly UserManager<Employee> userManager;
        private readonly IHttpContextAccessor httpContextAccessor;
        private readonly ILeaveAllocationRepository leaveAllocation;
        private readonly IEmailSender emailSender;

        public LeaveRequestRepository(ApplicationDbContext context,
                                        IMapper mapper,
                                        UserManager<Employee> userManager,
                                        IHttpContextAccessor httpContextAccessor,
                                        ILeaveAllocationRepository leaveAllocation,
                                        IEmailSender emailSender) : base(context)
        {
            this.context = context;
            this.mapper = mapper;
            this.userManager = userManager;
            this.httpContextAccessor = httpContextAccessor;
            this.leaveAllocation = leaveAllocation;
            this.emailSender = emailSender;
        }

        public async Task CancelLeaveRequest(int id)
        {
            var leaveRequest = await GetAsync(id);
            if(leaveRequest != null)
            {
                leaveRequest.Cancelled = true;
                await UpdateAsync(leaveRequest);
            }
            
        }

        public async Task ChangeApprovalStatus(int leaveRequestId, bool approved)
        {
            var leaveRequest = await GetAsync(leaveRequestId);
            leaveRequest.Approved = approved;
            if (approved)
            {
                var allocation = await leaveAllocation.GetEmployeeAllocation(leaveRequest.RequestingEmployeeId, leaveRequest.LeaveTypeId);
                allocation.NumberOfDays -= (int)(leaveRequest.EndDate - leaveRequest.StartDate).TotalDays;
                await leaveAllocation.UpdateAsync(allocation);
            }
            await UpdateAsync(leaveRequest);
        }

        public async Task<bool> CreateLeaveRequest(LeaveRequestCreateVM model)
        {
            if (model.StartDate < DateTime.Today || model.EndDate < DateTime.Today)
                return false;
            var user = await userManager.GetUserAsync(httpContextAccessor.HttpContext.User);
            var allocation = await leaveAllocation.GetEmployeeAllocation(user.Id, model.LeaveTypeId);
            if (allocation == null)
                return false;
            var leaveRequest = mapper.Map<LeaveRequest>(model);
            if (leaveRequest == null)
                return false;
            var daysRequested =(int) (model.EndDate.Value - model.StartDate.Value).TotalDays;
            if (allocation.NumberOfDays < daysRequested)
                return false;
            leaveRequest.DateRequested = DateTime.Now;
            var employee = await userManager.GetUserAsync(httpContextAccessor?.HttpContext?.User);
            leaveRequest.RequestingEmployeeId = employee.Id;
            await AddAsync(leaveRequest);
            await emailSender.SendEmailAsync(user.Email, "Leave Request Submitted Successfully", $"Your leave request from {leaveRequest.StartDate} to {leaveRequest.EndDate} has been created successfully, You will be notified when an action has been taken on it");
            return true;
        }

        public async Task<AdminLeaveRequestVM> GetAdminLeaveRequests()
        {
            var leaveRequests = await context.LeaveRequests.Include(q => q.LeaveType).ToListAsync();
            var model = new AdminLeaveRequestVM
            {
                TotalRequest = leaveRequests.Count(),
                ApprovedRequest = leaveRequests.Count(q => q.Approved == true),
                RejectedRequest = leaveRequests.Count(q => q.Approved == false),
                LeaveRequests = mapper.Map<List<LeaveRequestVM>>(leaveRequests)
            };
            var cancelled = leaveRequests.Count(q => q.Cancelled == true);
            model.PendingRequest = leaveRequests.Count(q => q.Approved == null) - cancelled;
            foreach(var leaveRequest in model.LeaveRequests)
            {
                leaveRequest.Employee = mapper.Map<EmployeeListVM>(await userManager.FindByIdAsync(leaveRequest.RequestingEmployeeId));
            }

            return model;
        }

        public async Task<LeaveRequestVM> GetLeaveRequest(int id)
        {
            var leaveRequest = mapper.Map<LeaveRequestVM>(await context.LeaveRequests.Include(q => q.LeaveType).FirstOrDefaultAsync(q => q.Id == id));
            var employee = mapper.Map<EmployeeListVM>(await userManager.FindByIdAsync(leaveRequest.RequestingEmployeeId));
            leaveRequest.Employee = employee;
            return leaveRequest;
        }

        public async Task<EmployeeLeaveRequestVM> GetMyLeaveDetails()
        {
            var user = await userManager.GetUserAsync(httpContextAccessor.HttpContext.User);
            var allocations =(await leaveAllocation.GetEmployeeAllocations(user.Id)).leaveAllocations;
            var leaveRequests = mapper.Map<List<LeaveRequestVM>>(await GetMyLeaveRequest(user.Id));
            var employeeLeaveRequestDetails = new EmployeeLeaveRequestVM
            {
                LeaveAllocations = allocations,
                LeaveRequests =  leaveRequests
            };
            return employeeLeaveRequestDetails;
        }

        public async Task<List<LeaveRequest>> GetMyLeaveRequest(string employeeId)
        {
            return await context.LeaveRequests.Where(q => q.RequestingEmployeeId == employeeId).ToListAsync();
        }
    }
}

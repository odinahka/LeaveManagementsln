
using AutoMapper;
using AutoMapper.QueryableExtensions;
using LeaveManagement.Web.Constants;
using LeaveManagement.Web.Contracts;
using LeaveManagement.Web.Data;
using LeaveManagement.Web.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagement.Web.Repository
{
    public class LeaveAllocationRepository : GenericRepository<LeaveAllocation>, ILeaveAllocationRepository
    {
        private readonly ApplicationDbContext context;
        private readonly UserManager<Employee> userManager;
        private readonly ILeaveTypeRepository leaveTypeRepository;
        private readonly IMapper mapper;
        private readonly AutoMapper.IConfigurationProvider configurationProvider;

        public LeaveAllocationRepository(ApplicationDbContext context,
                                            UserManager<Employee> userManager, 
                                            ILeaveTypeRepository leaveTypeRepository,
                                            IMapper mapper,
                                            AutoMapper.IConfigurationProvider configurationProvider) : base(context)
        {
            this.context = context;
            this.userManager = userManager;
            this.leaveTypeRepository = leaveTypeRepository;
            this.mapper = mapper;
            this.configurationProvider = configurationProvider;
        }

        public async Task<bool> AllocationExists(int leaveTypeId, string employeeId, int period)
        {
            return await context.LeaveAllocations.AnyAsync(e => e.EmployeeId == employeeId 
                                                                && e.LeaveTypeId == leaveTypeId
                                                                && e.Period == period);
        }

        public async Task<EmployeeAllocationVM> GetEmployeeAllocations(string employeeId)
        {
            var allocations = await context.LeaveAllocations
                .Include(q => q.LeaveType)
                .Where(q => q.EmployeeId == employeeId)
                .ProjectTo<LeaveAllocationVM>(configurationProvider)
                .ToListAsync();
            var employees = await userManager.FindByIdAsync(employeeId);
            var employeeLeaveAllocationModel = mapper.Map<EmployeeAllocationVM>(employees);
            employeeLeaveAllocationModel.leaveAllocations = allocations;
            
            return employeeLeaveAllocationModel;
        }

        public async Task<LeaveAllocationEditVM> GetEmployeeAllocation(int id)
        {
         
            var allocation = await context.LeaveAllocations
                .Include(q => q.LeaveType)
                .FirstOrDefaultAsync(q => q.Id == id);
            if (allocation == null)
                return null;

            allocation = allocation;

            var employee = await userManager.FindByIdAsync(allocation.EmployeeId);
            var model = mapper.Map<LeaveAllocationEditVM>(allocation);
            model.Employee = mapper.Map<EmployeeListVM>(employee);

            return model;
        }

        public async Task LeaveAllocation(int leaveTypeId)
        {
            var employees = await userManager.GetUsersInRoleAsync(Roles.User);
            var period = DateTime.Now.Year;
            var leaveType = await leaveTypeRepository.GetAsync(leaveTypeId);
            var allocations = new List<LeaveAllocation>();

            foreach( var employee in employees)
            {
              if (await AllocationExists(leaveTypeId, employee.Id, period))
                 continue;
                allocations.Add(new LeaveAllocation
                {
                    EmployeeId = employee.Id,
                    LeaveTypeId = leaveTypeId,
                    Period = period,
                    NumberOfDays = leaveType.DefaultDays
                });  
            }
            await AddRangeAsync(allocations);
        }

        public async Task<bool> UpdateEmployeeAllocation(LeaveAllocationEditVM model)
        {
            var leaveAllocation = await GetAsync(model.Id);
            if (leaveAllocation == null)
             return false;
            leaveAllocation.Period = model.Period;
            leaveAllocation.NumberOfDays = model.NumberOfDays;
            await UpdateAsync(leaveAllocation);
            return true;
        }

        public async Task<LeaveAllocation?> GetEmployeeAllocation(string employeeId, int leaveTypeId)
        {
           return await context.LeaveAllocations.FirstOrDefaultAsync(q => q.EmployeeId == employeeId && q.LeaveTypeId == leaveTypeId);
        }
    }
}

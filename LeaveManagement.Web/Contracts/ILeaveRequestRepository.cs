using LeaveManagement.Web.Data;
using LeaveManagement.Web.Models;

namespace LeaveManagement.Web.Contracts
{
    public interface ILeaveRequestRepository : IGenericRepository<LeaveRequest>
    {
        Task<bool> CreateLeaveRequest(LeaveRequestCreateVM model);
        Task<EmployeeLeaveRequestVM> GetMyLeaveDetails();
        Task<List<LeaveRequest>> GetMyLeaveRequest(string employeeId);
        Task<AdminLeaveRequestVM> GetAdminLeaveRequests();
        Task<LeaveRequestVM> GetLeaveRequest(int id);
        Task ChangeApprovalStatus(int leaveRequestId, bool approved);
        Task CancelLeaveRequest(int id);
    }
}

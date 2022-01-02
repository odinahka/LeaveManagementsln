using LeaveManagement.Data;
using LeaveManagement.Common.Models;

namespace LeaveManagement.Application.Contracts
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

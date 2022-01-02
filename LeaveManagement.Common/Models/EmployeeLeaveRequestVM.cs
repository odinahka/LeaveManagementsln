namespace LeaveManagement.Common.Models
{
    public class EmployeeLeaveRequestVM
    {
        public List<LeaveAllocationVM> LeaveAllocations { get; set; }
        public List<LeaveRequestVM> LeaveRequests { get; set; }
    }
}

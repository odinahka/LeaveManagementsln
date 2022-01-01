using System.ComponentModel.DataAnnotations;

namespace LeaveManagement.Web.Models
{
    public class AdminLeaveRequestVM
    {
        [Display(Name = "Total Leave Requests")]
        public int TotalRequest { get; set; }
        [Display(Name = "Approved Requests")]
        public int ApprovedRequest { get; set; }
        [Display(Name = "Pending Requests")]
        public int PendingRequest { get; set; }
        [Display(Name = "Cancelled Requests")]
        public int RejectedRequest { get; set; }
        public List<LeaveRequestVM> LeaveRequests { get; set; }
    }
}

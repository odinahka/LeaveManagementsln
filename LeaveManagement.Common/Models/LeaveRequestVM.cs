using System.ComponentModel.DataAnnotations;

namespace LeaveManagement.Common.Models
{
    public class LeaveRequestVM
    {
        public int Id { get; set; }
        [Display(Name ="Start Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }
        [Display(Name = "End Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }
        [Display(Name = "Leave Type")]
        public LeaveTypeVM LeaveType { get; set; }
        [Display(Name = "Date Requested")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        [DataType(DataType.Date)]
        public DateTime DateRequested { get; set; }
        public bool? Approved { get; set; }
        public bool Cancelled { get; set; }
        public string? RequestingEmployeeId { get; set; }
        public EmployeeListVM Employee { get; set; }
        [Display(Name = "Request Comments")]
        public string RequestComments { get; set; }
    }
}

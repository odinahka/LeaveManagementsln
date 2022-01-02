using System.ComponentModel.DataAnnotations;

namespace LeaveManagement.Common.Models
{
    public class LeaveAllocationVM
    {
        [Required]
        public int Id { get; set; }
        [Display(Name = "Number of Days")]
        [Required]
        [Range(1,50, ErrorMessage = "Invalid Number Of Days Entered")]
        public int NumberOfDays { set; get; }
        [Required]
        public int Period { set; get; }
        public LeaveTypeVM? LeaveType { set; get; }

    }
}
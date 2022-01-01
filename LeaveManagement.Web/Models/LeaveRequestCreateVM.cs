using LeaveManagement.Web.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace LeaveManagement.Web.Models
{
    public class LeaveRequestCreateVM : IValidatableObject
    {
        [Required]
        [Display(Name = "Start Date")]
        public DateTime? StartDate { get; set; }
        [Required]
        [Display(Name = "End Date")]
        public DateTime? EndDate { get; set; }
        [Required]
        [Display(Name = "Leave Type")]
        public int LeaveTypeId { get; set; }
        public SelectList? LeaveType { get; set; }
        [Display(Name = "Comments About Request")]
        public string? RequestComments { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if(StartDate > EndDate)
            { 
                yield return  new ValidationResult ("Start Date Must Not Be Greater than End Date", new[] { nameof(StartDate), nameof(EndDate) });
            }
        }
    }
}

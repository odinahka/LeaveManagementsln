﻿namespace LeaveManagement.Web.Models
{
    public class LeaveAllocationEditVM : LeaveAllocationVM
    {
        public EmployeeListVM? Employee { get; set; }
        public int LeaveTypeId { get; set; }
        public string EmployeeId { set; get; }
    }
}

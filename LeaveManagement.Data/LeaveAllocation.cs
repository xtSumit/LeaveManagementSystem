﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeaveManagement.Data
{
    public class LeaveAllocation: BaseEntity
    {
        public int NumberofDays { get; set; }
        
        [ForeignKey("LeaveTypeId")]
        public LeaveType LeaveType { get; set; }
        public int LeaveTypeId { get; set; }

        public string EmployeeId { get; set; }
        public int Period { get; set; }

    }
}

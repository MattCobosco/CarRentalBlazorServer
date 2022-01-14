﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreBusiness
{
    public class Assignment
    {
        public Assignment()
        {
            AssignmentGuid = Guid.NewGuid().ToString();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string AssignmentGuid { get; set; }
        [Required]
        public int AssignmentTypeId { get; set; }
        [Required]
        private bool IsDone { get; set; }
        public DateTime DateTime { get; set; }
        public string EmployeeGuid { get; set; }

        // Navigation properties for EF Core
        public AssignmentType AssignmentType { get; set; }
        public Employee Employee { get; set; }
        public Reservation StartReservation { get; set; }
        public Reservation EndReservation { get; set; }
        public Transfer Transfer { get; set; }
    }
}

using System;
using System.ComponentModel.DataAnnotations;

namespace CoreBusiness
{
    public class Transfer
    {
        public int TransferId { get; set; }
        [Required]
        public int FromBranchId { get; set; }
        [Required]
        public int ToBranchId { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public string FleetVehicleLicensePlate { get; set; }
        public string AssignmentGuid { get; set; }

        // Navigation properties for EF Core
        public Assignment Assignment { get; set; }
        public FleetVehicle FleetVehicle { get; set; }
        public Branch FromBranch { get; set; }
        public Branch ToBranch { get; set; }
    }
}

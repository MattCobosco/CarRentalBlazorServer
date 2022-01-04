using System;
using System.ComponentModel.DataAnnotations;

namespace CoreBusiness
{
    public class Transfer
    {
        public int TransferId { get; set; }
        [Required]
        public string FromBranch { get; set; }
        [Required]
        public string ToBranch { get; set; }
        [Required]
        public DateTime Date { get; set; }
        public int EmployeeId { get; set; }
        [Required]
        public string FleetVehicleLicensePlate { get; set; }
    }
}

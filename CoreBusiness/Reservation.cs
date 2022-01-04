using System;
using System.ComponentModel.DataAnnotations;

namespace CoreBusiness
{
    public class Reservation
    {
        public Guid ReservationGuid { get; set; }
        [Required]
        public DateTime StartDateTime { get; set; }
        [Required]
        public DateTime EndDateTime { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        public string BranchName { get; set; }
        public int EmployeeName { get; set; }
        [Required]
        public string FleetVehicleLicensePlate { get; set; }
        [Required]
        public int CustomerId { get; set; }
    }
}

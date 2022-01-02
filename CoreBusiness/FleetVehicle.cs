using System;
using System.ComponentModel.DataAnnotations;

namespace CoreBusiness
{
    public class FleetVehicle
    {
        public int FleetVehicleId;
        [Required]
        public string RegistrationPlate { get; set; }
        [Required]
        public int Odometer { get; set; }
        [Required]
        public string Vin { get; set; }
        [Required]
        public DateTime MaintenanceDate { get; set; }
        [Required]
        public int MaintenanceOdometer { get; set; }
        [Required]
        public DateTime DateAdded { get; set; }

        [Required]
        public int ModelVehicleId { get; set; }
        [Required]
        public int CurrentBranchId { get; set; }
    }
}

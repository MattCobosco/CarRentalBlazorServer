using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreBusiness
{
    public class FleetVehicle
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string FleetVehicleLicensePlate { get; set; }
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

        // Navigation properties for EF Core
        public VehicleModel VehicleModel { get; set; }
        public Branch Branch { get; set; }
    }
}

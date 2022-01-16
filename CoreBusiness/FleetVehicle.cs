using System;
using System.Collections.Generic;
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
        public int VehicleModelId { get; set; }
        [Required]
        public int CurrentBranchId { get; set; }

        public FleetVehicle()
        {
            DateAdded = DateTime.Today;
        }

        // Navigation properties for EF Core
        public VehicleModel VehicleModel { get; set; }
        public Branch CurrentBranch { get; set; }
        public List<Reservation> Reservations { get; set; }
        public List<Transfer> Transfers { get; set; }
        public List<Assignment> Assignments { get; set; }
    }
}

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreBusiness
{
    public class Reservation
    {
        public Reservation()
        {
            ReservationGuid = Guid.NewGuid().ToString();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string ReservationGuid { get; set; }
        [Required]
        public DateTime StartDateTime { get; set; }
        [Required]
        public DateTime EndDateTime { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        public int StartBranchId { get; set; }
        [Required]
        public int EndBranchId { get; set; }
        [Required]
        public int VehicleModelId { get; set; }
        public string FleetVehicleLicensePlate { get; set; }
        [Required]
        public string CustomerGuid { get; set; }
        public string StartAssignmentGuid { get; set; }
        public string EndAssignmentGuid { get; set; }

        // Navigation properties for EF Core
        public Branch StartBranch { get; set; }
        public Branch EndBranch { get; set; }
        public VehicleModel VehicleModel { get; set; }
        public FleetVehicle FleetVehicle { get; set; }
        public Customer Customer { get; set; }
        public Assignment StartAssignment { get; set; }
        public Assignment EndAssignment { get; set; }
    }
}

using System;
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
        public bool IsDone { get; set; }
        public DateTime DateTime { get; set; }
        public string EmployeeGuid { get; set; }
        public string ReservationGuid { get; set; }
        public string FleetVehicleLicensePlate { get; set; }
        public int VehicleModelId { get; set; }

        // Navigation properties for EF Core
        public AssignmentType AssignmentType { get; set; }
        public Employee Employee { get; set; }
        public Reservation Reservation { get; set; }
        public Transfer Transfer { get; set; }
        public FleetVehicle FleetVehicle { get; set; }
        public VehicleModel VehicleModel { get; set; }
    }
}

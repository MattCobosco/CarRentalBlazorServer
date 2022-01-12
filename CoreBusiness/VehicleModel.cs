using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CoreBusiness
{
    public class VehicleModel
    {
        public int VehicleModelId { get; set; }
        [Required]
        public string Make { get; set; }
        [Required]
        public string Model { get; set; }
        [Required]
        public string ModelYear { get; set; }
        [Required]
        public int BodyTypeId { get; set; }
        [Required]
        public string Segment { get; set; }
        [Required]
        public string EngineType { get; set; }
        [Required]
        public string Horsepower { get; set; }
        [Required]
        public bool AutomaticGearbox { get; set; }
        [Required]
        public int Doors { get; set; }
        [Required]
        public int Seats { get; set; }
        [Required]
        public int BaseDailyPrice { get; set; }

        // Navigation properties for EF Core
        public List<FleetVehicle> FleetVehicles { get; set; }
        public List<Reservation> Reservations { get; set; }
        public VehicleBodyType VehicleBodyType { get; set; }
    }
}

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CoreBusiness
{
    public class Branch
    {
        public int BranchId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        public string Description { get; set; }

        // Navigation properties for EF Core
        public List<FleetVehicle> FleetVehicles { get; set; }
        public List<Reservation> StartReservations { get; set; }
        public List<Reservation> EndReservations { get; set; }
        public List<Employee> Employees { get; set; }
    }
}

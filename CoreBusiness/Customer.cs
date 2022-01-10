using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CoreBusiness
{
    public class Customer
    {
        [Key]
        public string CustomerGuid { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactDetails { get; set; }
        public string Address { get; set; }
        public string PersonalDocumentNumber { get; set; }
        public string DrivingLicenseNumber { get; set; }
        public string Pesel { get; set; }

        // Navigation properties for EF Core
        public List<Reservation> Reservations { get; set; }
    }
}

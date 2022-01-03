using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreBusiness
{
    public class Customer
    {
        public int CustomerId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string ContactDetails { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string PersonalDocumentNumber { get; set; }
        [Required]
        public string DrivingLicenseNumber { get; set; }
    }
}

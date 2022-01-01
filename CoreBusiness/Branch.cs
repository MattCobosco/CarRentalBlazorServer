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
        [Required]
        public string City { get; set; }
        [Required]
        public string PostalCode { get; set; }
        public string Description { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace CoreBusiness
{
    public class VehicleBodyType
    {
        public int VehicleBodyTypeId { get; set; }
        [Required]
        public string Name { get; set; }
    }
}

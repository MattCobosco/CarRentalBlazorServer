using System.ComponentModel.DataAnnotations;

namespace CoreBusiness
{
    public class VehicleBodyType
    {
        public int VehicleBodyTypeId;
        [Required]
        public string Name { get; set; }
    }
}

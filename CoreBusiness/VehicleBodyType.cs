using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CoreBusiness
{
    public class VehicleBodyType
    {
        public int VehicleBodyTypeId { get; set; }
        [Required]
        public string Name { get; set; }

        // Navigation properties for EF Core
        public List<VehicleModel> VehicleModels { get; set; }
    }
}

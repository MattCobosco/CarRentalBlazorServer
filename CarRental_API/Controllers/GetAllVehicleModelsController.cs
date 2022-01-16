using CoreBusiness;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;

namespace CarRental_UI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetAllVehicleModelsController : ControllerBase
    {
        private readonly IVehicleModelRepository _vehicleModelRepository;

        public GetAllVehicleModelsController(IVehicleModelRepository vehicleModelRepository)
        {
            _vehicleModelRepository = vehicleModelRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<VehicleModel>> ShowAllVehicleModelsDetails()
        {
            return await _vehicleModelRepository.ViewVehicleModelsAsync();
        }
    }
}

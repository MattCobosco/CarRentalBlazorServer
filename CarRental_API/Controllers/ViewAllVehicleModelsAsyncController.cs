using System.Collections.Generic;
using System.Threading.Tasks;
using CoreBusiness;
using Microsoft.AspNetCore.Mvc;
using UseCases.DataStorePluginInterfaces;

namespace CarRental_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ViewAllVehicleModelsAsyncController : ControllerBase
    {
        private readonly IVehicleModelRepository _vehicleModelRepository;

        public ViewAllVehicleModelsAsyncController(IVehicleModelRepository vehicleModelRepository)
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

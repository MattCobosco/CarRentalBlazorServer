using CoreBusiness;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
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
        public IEnumerable<VehicleModel> ShowAllVehicleModelsDetails()
        {
            return _vehicleModelRepository.GetVehicleModels();
        }
    }
}

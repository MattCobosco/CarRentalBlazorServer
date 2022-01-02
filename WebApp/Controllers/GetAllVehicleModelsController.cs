using CoreBusiness;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using UseCases.DataStorePluginInterfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApp.Controllers
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

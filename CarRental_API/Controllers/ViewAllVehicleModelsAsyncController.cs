using CoreBusiness;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using UseCases.UseCaseInterfaces.VehicleModelUseCaseInterfaces;

namespace CarRental_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ViewAllVehicleModelsAsyncController : ControllerBase
    {
        private readonly IViewVehicleModelsAsyncUseCase _vueViewVehicleModelsAsyncUseCase;

        public ViewAllVehicleModelsAsyncController(IViewVehicleModelsAsyncUseCase viewVehicleModelsAsyncUseCase)
        {
            _vueViewVehicleModelsAsyncUseCase = viewVehicleModelsAsyncUseCase;
        }

        [HttpGet]
        public async Task<IEnumerable<VehicleModel>> ShowAllVehicleModelsDetails()
        {
            return await _vueViewVehicleModelsAsyncUseCase.Execute();
        }
    }
}

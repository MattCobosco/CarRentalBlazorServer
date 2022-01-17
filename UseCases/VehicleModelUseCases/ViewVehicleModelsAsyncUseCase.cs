using CoreBusiness;
using System.Collections.Generic;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;
using UseCases.UseCaseInterfaces.VehicleModelUseCaseInterfaces;

namespace UseCases.VehicleModelUseCases
{
    public class ViewVehicleModelsAsyncUseCase : IViewVehicleModelsAsyncUseCase
    {
        private readonly IVehicleModelRepository _vehicleModelRepository;

        public ViewVehicleModelsAsyncUseCase(IVehicleModelRepository vehicleModelRepository)
        {
            _vehicleModelRepository = vehicleModelRepository;
        }

        public async Task<IEnumerable<VehicleModel>> Execute()
        {
            return await _vehicleModelRepository.ViewVehicleModelsAsync();
        }
    }
}

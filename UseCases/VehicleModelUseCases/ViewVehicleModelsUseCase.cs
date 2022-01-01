using CoreBusiness;
using System.Collections.Generic;
using UseCases.DataStorePluginInterfaces;
using UseCases.UseCaseInterfaces.VehicleModelsUseCaseInterfaces;

namespace UseCases.VehicleModelUseCases
{
    public class ViewVehicleModelsUseCase : IViewVehicleModelsUseCase
    {
        private readonly IVehicleModelRepository _vehicleModelRepository;

        public ViewVehicleModelsUseCase(IVehicleModelRepository vehicleModelRepository)
        {
            _vehicleModelRepository = vehicleModelRepository;
        }

        public IEnumerable<VehicleModel> Execute()
        {
            return _vehicleModelRepository.GetVehicleModels();
        }
    }
}

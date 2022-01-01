using CoreBusiness;
using UseCases.DataStorePluginInterfaces;
using UseCases.UseCaseInterfaces.VehicleModelsUseCaseInterfaces;

namespace UseCases.VehicleModelUseCases
{
    public class GetVehicleModelByIdUseCase : IGetVehicleModelByIdUseCase
    {
        private readonly IVehicleModelRepository _vehicleModelRepository;

        public GetVehicleModelByIdUseCase(IVehicleModelRepository vehicleModelRepository)
        {
            _vehicleModelRepository = vehicleModelRepository;
        }

        public VehicleModel Execute(int vehicleModelId)
        {
            return _vehicleModelRepository.GetVehicleModelById(vehicleModelId);
        }
    }
}

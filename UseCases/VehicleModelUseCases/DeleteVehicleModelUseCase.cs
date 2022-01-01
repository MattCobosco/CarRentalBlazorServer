using UseCases.DataStorePluginInterfaces;
using UseCases.UseCaseInterfaces.VehicleModelsUseCaseInterfaces;

namespace UseCases.VehicleModelUseCases
{
    public class DeleteVehicleModelUseCase : IDeleteVehicleModelUseCase
    {
        private readonly IVehicleModelRepository _vehicleModelRepository;

        public DeleteVehicleModelUseCase(IVehicleModelRepository vehicleModelRepository)
        {
            _vehicleModelRepository = vehicleModelRepository;
        }

        public void Delete(int vehicleModelId)
        {
            _vehicleModelRepository.DeleteVehicleModel(vehicleModelId);
        }
    }
}

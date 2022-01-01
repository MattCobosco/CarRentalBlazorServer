using CoreBusiness;
using UseCases.DataStorePluginInterfaces;
using UseCases.UseCaseInterfaces.VehicleModelsUseCaseInterfaces;

namespace UseCases.VehicleModelUseCases
{
    public class EditVehicleModelUseCase : IEditVehicleModelUseCase
    {
        private readonly IVehicleModelRepository _vehicleModelRepository;

        public EditVehicleModelUseCase(IVehicleModelRepository vehicleModelRepository)
        {
            _vehicleModelRepository = vehicleModelRepository;
        }

        public void Execute(VehicleModel vehicleModel)
        {
            _vehicleModelRepository.EditVehicleModel(vehicleModel);
        }
    }
}

using CoreBusiness;
using UseCases.DataStorePluginInterfaces;
using UseCases.UseCaseInterfaces.VehicleModelUseCaseInterfaces;

namespace UseCases.VehicleModelUseCases
{
    public class AddVehicleModelUseCase : IAddVehicleModelUseCase
    {
        private readonly IVehicleModelRepository _vehicleModelRepository;

        public AddVehicleModelUseCase(IVehicleModelRepository vehicleModelRepository)
        {
            _vehicleModelRepository = vehicleModelRepository;
        }

        public void Execute(VehicleModel vehicleModel)
        {
            _vehicleModelRepository.AddVehicleModel(vehicleModel);
        }
    }
}

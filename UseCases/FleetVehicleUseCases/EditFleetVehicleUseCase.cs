using CoreBusiness;
using UseCases.DataStorePluginInterfaces;
using UseCases.UseCaseInterfaces.FleetVehicleUseCaseInterfaces;

namespace UseCases.FleetVehicleUseCases
{
    public class EditFleetVehicleUseCase : IEditFleetVehicleUseCase
    {
        private readonly IFleetVehicleRepository _fleetVehicleRepository;

        public EditFleetVehicleUseCase(IFleetVehicleRepository fleetVehicleRepository)
        {
            _fleetVehicleRepository = fleetVehicleRepository;
        }

        public void Execute(FleetVehicle fleetVehicle)
        {
            _fleetVehicleRepository.EditFleetVehicle(fleetVehicle);
        }
    }
}

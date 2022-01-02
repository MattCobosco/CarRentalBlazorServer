using CoreBusiness;
using UseCases.DataStorePluginInterfaces;
using UseCases.UseCaseInterfaces.FleetVehicleUseCaseInterfaces;

namespace UseCases.FleetVehicleUseCases
{
    public class AddFleetVehicleUseCase : IAddFleetVehicleUseCase
    {

        private readonly IFleetVehicleRepository _fleetVehicleRepository;

        public AddFleetVehicleUseCase(IFleetVehicleRepository fleetVehicleRepository)
        {
            _fleetVehicleRepository = fleetVehicleRepository;
        }

        public void Execute(FleetVehicle fleetVehicle)
        {
            _fleetVehicleRepository.AddFleetVehicle(fleetVehicle);
        }
    }
}

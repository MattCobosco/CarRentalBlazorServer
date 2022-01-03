using UseCases.DataStorePluginInterfaces;
using UseCases.UseCaseInterfaces.FleetVehicleUseCaseInterfaces;

namespace UseCases.FleetVehicleUseCases
{
    public class DeleteFleetVehicleUseCase : IDeleteFleetVehicleUseCase
    {
        private readonly IFleetVehicleRepository _fleetVehicleRepository;

        public DeleteFleetVehicleUseCase(IFleetVehicleRepository fleetVehicleRepository)
        {
            _fleetVehicleRepository = fleetVehicleRepository;
        }

        public void Delete(string fleetVehicleLicensePlate)
        {
            _fleetVehicleRepository.DeleteFleetVehicle(fleetVehicleLicensePlate);
        }
    }
}

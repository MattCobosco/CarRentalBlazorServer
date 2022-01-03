using CoreBusiness;
using UseCases.DataStorePluginInterfaces;
using UseCases.UseCaseInterfaces.FleetVehicleUseCaseInterfaces;

namespace UseCases.FleetVehicleUseCases
{
    public class GetFleetVehicleByLicensePlate : IGetFleetVehicleByLicensePlateUseCase
    {
        private readonly IFleetVehicleRepository _fleetVehicleRepository;

        public GetFleetVehicleByLicensePlate(IFleetVehicleRepository fleetVehicleRepository)
        {
            _fleetVehicleRepository = fleetVehicleRepository;
        }

        public FleetVehicle Execute(string fleetVehicleLicensePlate)
        {
            return _fleetVehicleRepository.GetFleetVehicleByLicensePlate(fleetVehicleLicensePlate);
        }
    }
}

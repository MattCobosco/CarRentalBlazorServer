using CoreBusiness;
using UseCases.DataStorePluginInterfaces;
using UseCases.UseCaseInterfaces.VehicleModelUseCaseInterfaces;

namespace UseCases.VehicleModelUseCases
{
    public class GetVehicleModelByLicensePlateUseCase : IGetVehicleModelByLicensePlateUseCase
    {
        private readonly IVehicleModelRepository _vehicleModelRepository;
        private readonly IFleetVehicleRepository _fleetVehicleRepository;

        public GetVehicleModelByLicensePlateUseCase(
            IVehicleModelRepository vehicleModelRepository,
            IFleetVehicleRepository fleetVehicleRepository)
        {
            _vehicleModelRepository = vehicleModelRepository;
            _fleetVehicleRepository = fleetVehicleRepository;
        }

        public VehicleModel Execute(string fleetVehicleLicensePlate)
        {
            var fleetVehicle = _fleetVehicleRepository.GetFleetVehicleByLicensePlate(fleetVehicleLicensePlate);
            var vehicleModel = _vehicleModelRepository.GetVehicleModelById(fleetVehicle.VehicleModelId);
            return vehicleModel;
        }
    }
}

using CoreBusiness;
using UseCases.DataStorePluginInterfaces;
using UseCases.UseCaseInterfaces.FleetVehicleUseCaseInterfaces;

namespace UseCases.FleetVehicleUseCases
{
    public class GetFleetVehicleByIdUseCase : IGetFleetVehicleByIdUseCase
    {
        private readonly IFleetVehicleRepository _fleetVehicleRepository;

        public GetFleetVehicleByIdUseCase(IFleetVehicleRepository fleetVehicleRepository)
        {
            _fleetVehicleRepository = fleetVehicleRepository;
        }

        public FleetVehicle Execute(int fleetVehicleId)
        {
            return _fleetVehicleRepository.GetFleetVehicleById(fleetVehicleId);
        }
    }
}

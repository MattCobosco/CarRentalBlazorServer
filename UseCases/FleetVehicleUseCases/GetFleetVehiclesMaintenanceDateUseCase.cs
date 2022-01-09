using CoreBusiness;
using System.Collections.Generic;
using UseCases.DataStorePluginInterfaces;
using UseCases.UseCaseInterfaces.FleetVehicleUseCaseInterfaces;

namespace UseCases.FleetVehicleUseCases
{
    public class GetFleetVehiclesMaintenanceDateUseCase : IGetFleetVehiclesMaintenanceDateUseCase
    {
        private readonly IFleetVehicleRepository _fleetVehicleRepository;

        public GetFleetVehiclesMaintenanceDateUseCase(IFleetVehicleRepository fleetVehicleRepository)
        {
            _fleetVehicleRepository = fleetVehicleRepository;
        }

        public IEnumerable<FleetVehicle> Execute()
        {
            return _fleetVehicleRepository.GetFleetVehicleMaintenanceDate();
        }
    }
}

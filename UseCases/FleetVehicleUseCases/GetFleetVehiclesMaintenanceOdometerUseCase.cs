using CoreBusiness;
using System.Collections.Generic;
using UseCases.DataStorePluginInterfaces;
using UseCases.UseCaseInterfaces.FleetVehicleUseCaseInterfaces;

namespace UseCases.FleetVehicleUseCases
{
    public class GetFleetVehiclesMaintenanceOdometerUseCase : IGetFleetVehiclesMaintenanceOdometerUseCase
    {
        private readonly IFleetVehicleRepository _fleetVehicleRepository;

        public GetFleetVehiclesMaintenanceOdometerUseCase(IFleetVehicleRepository fleetVehicleRepository)
        {
            _fleetVehicleRepository = fleetVehicleRepository;
        }

        public IEnumerable<FleetVehicle> Execute()
        {
            return _fleetVehicleRepository.GetFleetVehicleMaintenanceOdometer();
        }
    }
}

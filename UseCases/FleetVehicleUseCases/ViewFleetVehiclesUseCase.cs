using CoreBusiness;
using System.Collections.Generic;
using UseCases.DataStorePluginInterfaces;
using UseCases.UseCaseInterfaces.FleetVehicleUseCaseInterfaces;

namespace UseCases.FleetVehicleUseCases
{
    public class ViewFleetVehiclesUseCase : IViewFleetVehiclesUseCase
    {
        private readonly IFleetVehicleRepository _fleetVehicleRepository;

        public ViewFleetVehiclesUseCase(IFleetVehicleRepository fleetVehicleRepository)
        {
            _fleetVehicleRepository = fleetVehicleRepository;
        }

        public IEnumerable<FleetVehicle> Execute()
        {
            return _fleetVehicleRepository.GetFleetVehicles();
        }
    }
}

using CoreBusiness;
using System.Collections.Generic;

namespace UseCases.UseCaseInterfaces.FleetVehicleUseCaseInterfaces
{
    public interface IGetFleetVehiclesMaintenanceOdometerUseCase
    {
        IEnumerable<FleetVehicle> Execute();
    }
}

using CoreBusiness;
using System.Collections.Generic;

namespace UseCases.UseCaseInterfaces.FleetVehicleUseCaseInterfaces
{
    public interface IGetFleetVehiclesMaintenanceDateUseCase
    {
        IEnumerable<FleetVehicle> Execute();
    }
}

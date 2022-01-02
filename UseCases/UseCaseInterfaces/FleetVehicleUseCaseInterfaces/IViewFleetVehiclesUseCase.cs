using CoreBusiness;
using System.Collections.Generic;

namespace UseCases.UseCaseInterfaces.FleetVehicleUseCaseInterfaces
{
    public interface IViewFleetVehiclesUseCase
    {
        IEnumerable<FleetVehicle> Execute();
    }
}

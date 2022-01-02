using CoreBusiness;

namespace UseCases.UseCaseInterfaces.FleetVehicleUseCaseInterfaces
{
    public interface IGetFleetVehicleByIdUseCase
    {
        FleetVehicle Execute(int fleetVehicleId);
    }
}

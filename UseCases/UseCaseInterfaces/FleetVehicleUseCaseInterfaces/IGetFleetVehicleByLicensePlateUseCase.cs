using CoreBusiness;

namespace UseCases.UseCaseInterfaces.FleetVehicleUseCaseInterfaces
{
    public interface IGetFleetVehicleByLicensePlateUseCase
    {
        FleetVehicle Execute(string fleetVehicleLicensePlate);
    }
}

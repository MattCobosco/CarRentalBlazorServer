using CoreBusiness;

namespace UseCases.UseCaseInterfaces.VehicleModelUseCaseInterfaces
{
    public interface IGetVehicleModelByLicensePlateUseCase
    {
        VehicleModel Execute(string licensePlate);
    }
}

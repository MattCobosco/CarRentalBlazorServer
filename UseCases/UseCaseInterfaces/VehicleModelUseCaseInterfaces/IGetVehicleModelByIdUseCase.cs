using CoreBusiness;

namespace UseCases.UseCaseInterfaces.VehicleModelUseCaseInterfaces
{
    public interface IGetVehicleModelByIdUseCase
    {
        VehicleModel Execute(int vehicleModelId);
    }
}

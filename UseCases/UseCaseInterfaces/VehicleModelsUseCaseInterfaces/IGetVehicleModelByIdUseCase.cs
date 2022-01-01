using CoreBusiness;

namespace UseCases.UseCaseInterfaces.VehicleModelsUseCaseInterfaces
{
    public interface IGetVehicleModelByIdUseCase
    {
        VehicleModel Execute(int vehicleModelId);
    }
}

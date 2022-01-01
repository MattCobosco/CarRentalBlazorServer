using CoreBusiness;

namespace UseCases.UseCaseInterfaces.VehicleModelsUseCaseInterfaces
{
    public interface IGetVehicleModelById
    {
        VehicleModel Execute(int vehicleModelId);
    }
}

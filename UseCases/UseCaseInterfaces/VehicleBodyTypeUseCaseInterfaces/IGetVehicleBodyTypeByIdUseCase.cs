using CoreBusiness;

namespace UseCases.UseCaseInterfaces.VehicleBodyTypeUseCaseInterfaces
{
    public interface IGetVehicleBodyTypeByIdUseCase
    {
        VehicleBodyType Execute(int vehicleBodyTypeId);
    }
}

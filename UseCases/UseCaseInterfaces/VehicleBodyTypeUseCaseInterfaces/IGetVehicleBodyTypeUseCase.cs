using CoreBusiness;

namespace UseCases.UseCaseInterfaces.VehicleBodyTypeUseCaseInterfaces
{
    interface IGetVehicleBodyTypeUseCase
    {
        VehicleBodyType Execute(int vehicleBodyTypeId);
    }
}

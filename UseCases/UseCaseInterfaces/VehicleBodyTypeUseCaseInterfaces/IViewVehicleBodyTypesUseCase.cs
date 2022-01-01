using System.Collections.Generic;
using CoreBusiness;

namespace UseCases.UseCaseInterfaces.VehicleBodyTypeUseCaseInterfaces
{
    public interface IViewVehicleBodyTypesUseCase
    {
        IEnumerable<VehicleBodyType> Execute();
    }
}

using CoreBusiness;
using System.Collections.Generic;

namespace UseCases.UseCaseInterfaces.VehicleBodyTypeUseCaseInterfaces
{
    public interface IViewVehicleBodyTypesUseCase
    {
        IEnumerable<VehicleBodyType> Execute();
    }
}

using System.Collections.Generic;
using CoreBusiness;

namespace UseCases.UseCaseInterfaces.VehicleBodyTypeUseCaseInterfaces
{
    interface IViewVehicleBodyTypesUseCase
    {
        IEnumerable<VehicleBodyType> Execute();
    }
}

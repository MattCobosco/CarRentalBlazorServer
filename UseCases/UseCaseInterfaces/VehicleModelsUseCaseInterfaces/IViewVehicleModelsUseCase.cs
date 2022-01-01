using System.Collections.Generic;
using CoreBusiness;

namespace UseCases.UseCaseInterfaces.VehicleModelsUseCaseInterfaces
{
    public interface IViewVehicleModelsUseCase
    {
        IEnumerable<VehicleModel> Execute();
    }
}

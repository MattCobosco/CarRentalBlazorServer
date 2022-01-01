using CoreBusiness;
using System.Collections.Generic;

namespace UseCases.UseCaseInterfaces.VehicleModelsUseCaseInterfaces
{
    public interface IViewVehicleModelsUseCase
    {
        IEnumerable<VehicleModel> Execute();
    }
}

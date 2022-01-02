using System.Collections.Generic;
using CoreBusiness;

namespace UseCases.UseCaseInterfaces.VehicleModelUseCaseInterfaces
{
    public interface IViewVehicleModelsUseCase
    {
        IEnumerable<VehicleModel> Execute();
    }
}

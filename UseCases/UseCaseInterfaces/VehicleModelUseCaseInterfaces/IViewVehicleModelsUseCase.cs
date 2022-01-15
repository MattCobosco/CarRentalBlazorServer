using CoreBusiness;
using System.Collections.Generic;

namespace UseCases.UseCaseInterfaces.VehicleModelUseCaseInterfaces
{
    public interface IViewVehicleModelsUseCase
    {
        IEnumerable<VehicleModel> Execute();
    }
}

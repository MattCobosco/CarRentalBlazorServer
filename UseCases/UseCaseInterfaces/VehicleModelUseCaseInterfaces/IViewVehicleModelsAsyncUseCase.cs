using CoreBusiness;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace UseCases.UseCaseInterfaces.VehicleModelUseCaseInterfaces
{
    public interface IViewVehicleModelsAsyncUseCase
    {
        Task<IEnumerable<VehicleModel>> Execute();
    }
}

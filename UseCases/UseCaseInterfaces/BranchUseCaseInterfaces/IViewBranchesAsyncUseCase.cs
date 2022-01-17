using CoreBusiness;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace UseCases.UseCaseInterfaces.BranchUseCaseInterfaces
{
    public interface IViewBranchesAsyncUseCase
    {
        Task<IEnumerable<Branch>> Execute();
    }
}

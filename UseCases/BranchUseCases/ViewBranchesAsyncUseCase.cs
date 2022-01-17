using CoreBusiness;
using System.Collections.Generic;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;
using UseCases.UseCaseInterfaces.BranchUseCaseInterfaces;

namespace UseCases.BranchUseCases
{
    public class ViewBranchesAsyncUseCase : IViewBranchesAsyncUseCase
    {
        private readonly IBranchRepository _branchRepository;

        public ViewBranchesAsyncUseCase(IBranchRepository branchRepository)
        {
            _branchRepository = branchRepository;
        }

        public async Task<IEnumerable<Branch>> Execute()
        {
            return await _branchRepository.ViewBranchesAsync();
        }
    }
}

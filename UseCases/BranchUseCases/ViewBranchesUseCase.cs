using CoreBusiness;
using System.Collections.Generic;
using UseCases.DataStorePluginInterfaces;
using UseCases.UseCaseInterfaces.BranchUseCaseInterfaces;

namespace UseCases.BranchUseCases
{
    public class ViewBranchesUseCase : IViewBranchesUseCase
    {
        private readonly IBranchRepository _branchRepository;

        public ViewBranchesUseCase(IBranchRepository branchesRepository)
        {
            _branchRepository = branchesRepository;
        }

        public IEnumerable<Branch> Execute()
        {
            return _branchRepository.ViewBranches();
        }
    }
}

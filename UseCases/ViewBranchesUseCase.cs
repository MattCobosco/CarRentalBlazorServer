using CoreBusiness;
using System.Collections.Generic;
using UseCases.DataStorePluginInterfaces;
using UseCases.UseCaseInterfaces;

namespace UseCases
{
    public class ViewBranchesUseCase : IViewBranchesUseCase

    {
        private readonly IBranchRepository _branchRepository;

        public ViewBranchesUseCase(IBranchRepository _branchesRepository)
        {
            this._branchRepository = _branchesRepository;
        }

        public IEnumerable<Branch> Execute()
        {
            return _branchRepository.GetBranches();
        }
    }
}

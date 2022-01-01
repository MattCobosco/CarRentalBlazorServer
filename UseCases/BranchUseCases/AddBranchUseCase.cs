using CoreBusiness;
using UseCases.DataStorePluginInterfaces;
using UseCases.UseCaseInterfaces.BranchUseCaseInterfaces;

namespace UseCases.BranchUseCases
{
    public class AddBranchUseCase : IAddBranchUseCase
    {
        private readonly IBranchRepository _branchRepository;

        public AddBranchUseCase(IBranchRepository branchesRepository)
        {
            _branchRepository = branchesRepository;
        }

        public void Execute(Branch branch)
        {
            _branchRepository.AddBranch(branch);
        }
    }
}

using CoreBusiness;
using UseCases.DataStorePluginInterfaces;
using UseCases.UseCaseInterfaces.BranchUseCaseInterfaces;

namespace UseCases.BranchUseCases
{
    public class EditBranchUseCase : IEditBranchUseCase
    {
        private readonly IBranchRepository _branchRepository;

        public EditBranchUseCase(IBranchRepository branchRepository)
        {
            _branchRepository = branchRepository;
        }

        public void Execute(Branch branch)
        {
            _branchRepository.EditBranch(branch);
        }
    }
}

using UseCases.DataStorePluginInterfaces;
using UseCases.UseCaseInterfaces.BranchUseCaseInterfaces;

namespace UseCases.BranchUseCases
{
    public class DeleteBranchUseCase : IDeleteBranchUseCase
    {
        private readonly IBranchRepository _branchRepository;

        public DeleteBranchUseCase(IBranchRepository branchRepository)
        {
            _branchRepository = branchRepository;
        }

        public void Delete(int branchId)
        {
            _branchRepository.DeleteBranch(branchId);
        }
    }
}

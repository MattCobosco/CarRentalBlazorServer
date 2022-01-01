using UseCases.DataStorePluginInterfaces;
using UseCases.UseCaseInterfaces;

namespace UseCases
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

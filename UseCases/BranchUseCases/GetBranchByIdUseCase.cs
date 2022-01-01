using CoreBusiness;
using UseCases.DataStorePluginInterfaces;
using UseCases.UseCaseInterfaces.BranchUseCaseInterfaces;

namespace UseCases.BranchUseCases
{
    public class GetBranchByIdUseCase : IGetBranchByIdUseCase
    {
        private readonly IBranchRepository _branchRepository;

        public GetBranchByIdUseCase(IBranchRepository branchRepository)
        {
            _branchRepository = branchRepository;
        }

        public Branch Execute(int branchId)
        {
            return _branchRepository.GetBranchById(branchId);
        }
    }
}

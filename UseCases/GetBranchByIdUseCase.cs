using CoreBusiness;
using UseCases.DataStorePluginInterfaces;
using UseCases.UseCaseInterfaces;

namespace UseCases
{
    public class GetBranchByIdUseCase : IGetBranchByIdUseCase
    {
        private IBranchRepository _branchRepository;
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

using CoreBusiness;

namespace UseCases.UseCaseInterfaces.BranchUseCaseInterfaces
{
    public interface IGetBranchByIdUseCase
    {
        Branch Execute(int branchId);
    }
}

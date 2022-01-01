using CoreBusiness;

namespace UseCases.UseCaseInterfaces
{
    public interface IGetBranchByIdUseCase
    {
        Branch Execute(int branchId);
    }
}

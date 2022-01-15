using CoreBusiness;
using System.Collections.Generic;

namespace UseCases.UseCaseInterfaces.BranchUseCaseInterfaces
{
    public interface IViewBranchesUseCase
    {
        IEnumerable<Branch> Execute();
    }
}

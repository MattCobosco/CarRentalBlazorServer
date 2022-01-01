using System.Collections.Generic;
using CoreBusiness;

namespace UseCases.UseCaseInterfaces.BranchUseCaseInterfaces
{
    public interface IViewBranchesUseCase
    {
        IEnumerable<Branch> Execute();
    }
}

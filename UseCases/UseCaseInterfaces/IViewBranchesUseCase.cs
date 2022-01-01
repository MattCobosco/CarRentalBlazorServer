using System.Collections.Generic;
using CoreBusiness;

namespace UseCases.UseCaseInterfaces
{
    public interface IViewBranchesUseCase
    {
        IEnumerable<Branch> Execute();
    }
}

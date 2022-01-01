using System.Collections.Generic;
using CoreBusiness;

namespace UseCases.DataStorePluginInterfaces
{
    public interface IBranchRepository
    {
        IEnumerable<Branch> GetBranches();
    }
}

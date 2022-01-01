using CoreBusiness;
using System.Collections.Generic;

namespace UseCases.DataStorePluginInterfaces
{
    public interface IBranchRepository
    {
        IEnumerable<Branch> GetBranches();
        void AddBranch(Branch branch);
        void EditBranch(Branch branch);
        Branch GetBranchById(int branchId);
    }
}

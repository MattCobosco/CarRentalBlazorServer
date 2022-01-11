using CoreBusiness;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace UseCases.DataStorePluginInterfaces
{
    public interface IBranchRepository
    {
        void AddBranch(Branch branch);
        void DeleteBranch(int branchId);
        void EditBranch(Branch branch);
        Branch GetBranchById(int branchId);
        IEnumerable<Branch> GetBranches();
        Task<IEnumerable<Branch>> GetBranchesAsync();
    }
}

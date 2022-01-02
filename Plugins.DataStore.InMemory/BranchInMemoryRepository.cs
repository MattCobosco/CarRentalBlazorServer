using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using UseCases.DataStorePluginInterfaces;

namespace Plugins.DataStore.InMemory
{
    public class BranchInMemoryRepository : IBranchRepository
    {
        private List<Branch> _branches;

        public BranchInMemoryRepository()
        {
            // Add default branches
            _branches = new List<Branch>
            {
                new() { BranchId = 1, Name = "Gdańsk", Address = "Szklary 138", City = "Gdańsk", PostalCode = "80-835"},
                new() { BranchId = 2, Name = "Warszawa", Address = "Rozłogi 1", City = "Warszawa", PostalCode = "01-323" },
                new() { BranchId = 3, Name = "Kraków - Airport", Address = "Olszanicka 174", City = "Balice", PostalCode = "30-241" },
                new() { BranchId = 4, Name = "Kraków - City", Address = "Conrada 63", City = "Kraków", PostalCode = "31-357" }
            };
        }

        public IEnumerable<Branch> GetBranches()
        {
            return _branches;
        }

        public void AddBranch(Branch branch)
        {
            if (_branches.Any(x => x.Name.Equals(branch.Name, StringComparison.OrdinalIgnoreCase)))
            {
                return;
            }

            if (_branches != null && _branches.Count > 0)
            {
                var maxId = _branches.Max(x => x.BranchId);

                branch.BranchId = maxId + 1;
                _branches.Add(branch);
            }
            else
            {
                branch.BranchId = 1;
            }
        }

        public void EditBranch(Branch branch)
        {
            var branchToEdit = GetBranchById(branch.BranchId);
            if (branchToEdit != null)
            {
                branchToEdit.Name = branch.Name;
                branchToEdit.Address = branch.Address;
                branchToEdit.City = branch.City;
                branchToEdit.PostalCode = branch.PostalCode;
                branchToEdit.Description = branch.Description;
            }
        }

        public Branch GetBranchById(int branchId)
        {
            return _branches?.FirstOrDefault(x => x.BranchId == branchId);
        }

        public void DeleteBranch(int branchId)
        {
            _branches?.Remove(GetBranchById(branchId));
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using CoreBusiness;
using UseCases.DataStorePluginInterfaces;

namespace Plugins.DataStore.InMemory
{
    public class BranchInMemoryRepository : IBranchRepository
    {
        private List<Branch> _branches;

        public BranchInMemoryRepository()
        {
            // Add default branches
            _branches = new List<Branch>()
            {
                new() { BranchId = 1, Name = "Gdańsk", Address = "Szklary 138", City = "Gdańsk", PostalCode = "80-835"},
                new() { BranchId = 2, Name = "Warszawa", Address = "Rozłogi 1", City = "Warszawa", PostalCode = "01-323" },
                new() { BranchId = 3, Name = "Kraków - miasto", Address = "Olszanicka 174", City = "Balice", PostalCode = "30-241" },
                new() { BranchId = 4, Name = "Kraków - Balice", Address = "Conrada 63", City = "Kraków", PostalCode = "31-357" }
            };
        }

        public IEnumerable<Branch> GetBranches()
        {
            return _branches;
        }

        public void AddBranch(Branch branch)
        {
            if(_branches.Any(x => x.Name.Equals(branch.Name, StringComparison.OrdinalIgnoreCase))) return;

            var maxId = _branches.Max(x => x.BranchId);

            branch.BranchId = maxId + 1;
            _branches.Add(branch);
        }
    }
}

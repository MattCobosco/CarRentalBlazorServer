using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using UseCases.DataStorePluginInterfaces;

namespace Plugins.DataStore.SQL
{
    public class BranchRepository : IBranchRepository
    {
        private readonly CarRentalContext _carRentalContext;

        public BranchRepository(CarRentalContext carRentalContext)
        {
            _carRentalContext = carRentalContext;
        }

        public void AddBranch(Branch branch)
        {
            var transaction = _carRentalContext.Database.BeginTransaction();

            if (_carRentalContext.Branches.Any(
                   x => x.Name == branch.Name ||
                        x.Address == branch.Address))
            {
                transaction.Rollback();
                Console.WriteLine("Warning: Such Branch already exists!");
                return;
            }

            try
            {
                _carRentalContext.Add(branch);
                _carRentalContext.SaveChanges();
                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                Console.WriteLine("Adding Branch failed:");
                Console.WriteLine(ex.Message);
            }
        }

        public void DeleteBranch(int branchId)
        {
            var transaction = _carRentalContext.Database.BeginTransaction();

            try
            {
                var branch = GetBranchById(branchId);

                if (branch == null)
                {
                    return;
                }

                _carRentalContext.Branches.Remove(branch);
                _carRentalContext.SaveChanges();
                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                Console.WriteLine("Deleting Branch failed:");
                Console.WriteLine(ex.Message);
            }
        }

        public void EditBranch(Branch branch)
        {
            var transaction = _carRentalContext.Database.BeginTransaction();

            try
            {
                var branchToEdit = GetBranchById(branch.BranchId);
                branchToEdit.Name = branch.Name;
                branchToEdit.Address = branch.Address;
                branchToEdit.Description = branch.Description;

                _carRentalContext.SaveChanges();
                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                Console.WriteLine("Editing Branch failed:");
                Console.WriteLine(ex.Message);
            }
        }

        public Branch GetBranchById(int branchId)
        {
            var branch = _carRentalContext.Branches.Find(branchId);

            if (branch != null)
            {
                return branch;
            }

            Console.WriteLine("Couldn't find the requested Branch!");
            return null;

        }

        public IEnumerable<Branch> GetBranches()
        {
            try
            {
                return _carRentalContext.Branches.ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Getting Branches failed:");
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}

using CoreBusiness;
using Microsoft.EntityFrameworkCore;
using Plugins.DataStore.SQL.Data;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;

namespace Plugins.DataStore.SQL
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly CarRentalContext _carRentalContext;

        public EmployeeRepository(CarRentalContext carRentalContext)
        {
            _carRentalContext = carRentalContext;
        }

        public void AddEmployee(Employee employee)
        {
            var transaction = _carRentalContext.Database.BeginTransaction();

            try
            {
                _carRentalContext.Add(employee);
                _carRentalContext.SaveChanges();
                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                Console.WriteLine("Adding Employee failed:");
                Console.WriteLine(ex.Message);
            }
        }

        public async Task<Employee> GetEmployeeByGuidAsync(string employeeGuid)
        {
            var employee = await _carRentalContext.Employees.FindAsync(employeeGuid);

            if (employee != null)
            {
                return employee;
            }

            Console.WriteLine("Couldn't find the requested Employee!");
            return null;
        }

        public async Task<IEnumerable<Employee>> GetEmployeesAsync()
        {
            try
            {
                return await _carRentalContext.Employees.ToListAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Getting Employees failed:");
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}

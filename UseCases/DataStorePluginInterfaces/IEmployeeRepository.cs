using CoreBusiness;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace UseCases.DataStorePluginInterfaces
{
    public interface IEmployeeRepository
    {
        void AddEmployee(Employee employee);
        Task<Employee> GetEmployeeByGuidAsync(string employeeGuid);
        Task<IEnumerable<Employee>> GetEmployeesAsync();
    }
}

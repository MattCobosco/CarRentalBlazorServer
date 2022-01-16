using CoreBusiness;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace UseCases.DataStorePluginInterfaces
{
    public interface IEmployeeRepository
    {
        void AddEmployee(Employee employee);
        Employee GetEmployeeByGuid(string employeeGuid);
        Task<IEnumerable<Employee>> ViewEmployeesAsync();
    }
}

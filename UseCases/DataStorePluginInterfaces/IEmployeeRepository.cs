using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreBusiness;

namespace UseCases.DataStorePluginInterfaces
{
    public interface IEmployeeRepository
    {
        void AddEmployee(Employee employee);
        Task<IEnumerable<Employee>> GetEmployees();
    }
}

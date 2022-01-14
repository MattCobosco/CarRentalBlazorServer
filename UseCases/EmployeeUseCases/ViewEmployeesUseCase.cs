using CoreBusiness;
using System.Collections.Generic;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;
using UseCases.UseCaseInterfaces.EmployeeUseCaseInterfaces;

namespace UseCases.EmployeeUseCases
{
    public class ViewEmployeesUseCase : IViewEmployeesUseCase
    {
        private readonly IEmployeeRepository _employeeRepository;

        public ViewEmployeesUseCase(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<IEnumerable<Employee>> Execute()
        {
            return await _employeeRepository.GetEmployees();
        }
    }
}

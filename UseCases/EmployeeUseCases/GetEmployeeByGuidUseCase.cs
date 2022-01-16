using CoreBusiness;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;
using UseCases.UseCaseInterfaces.EmployeeUseCaseInterfaces;

namespace UseCases.EmployeeUseCases
{
    public class GetEmployeeByGuidUseCase : IGetEmployeeByGuidUseCase
    {
        private readonly IEmployeeRepository _employeeRepository;

        public GetEmployeeByGuidUseCase(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public Employee Execute(string employeeGuid)
        {
            return _employeeRepository.GetEmployeeByGuid(employeeGuid);
        }

    }
}

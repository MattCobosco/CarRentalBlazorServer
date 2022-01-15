using CoreBusiness;
using UseCases.DataStorePluginInterfaces;
using UseCases.IdentityStoreUseCaseInterfaces;
using UseCases.UseCaseInterfaces.EmployeeUseCaseInterfaces;

namespace UseCases.EmployeeUseCases
{
    public class AddEmployeeUseCase : IAddEmployeeUseCase
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IUserRepository _userRepository;

        public AddEmployeeUseCase(
            IEmployeeRepository employeeRepository,
            IUserRepository userRepository)
        {
            _employeeRepository = employeeRepository;
            _userRepository = userRepository;
        }

        public void Execute(Employee employee, string username, string email, string password, string claimValue)
        {
            string employeeGuid = _userRepository.AddUser(username, email, password, claimValue);

            employee.EmployeeGuid = employeeGuid;
            _employeeRepository.AddEmployee(employee);

        }
    }
}

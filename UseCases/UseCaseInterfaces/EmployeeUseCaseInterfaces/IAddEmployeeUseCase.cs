using CoreBusiness;

namespace UseCases.UseCaseInterfaces.EmployeeUseCaseInterfaces
{
    public interface IAddEmployeeUseCase
    {
        void Execute(Employee employee, string username, string email, string password, string claimValue);
    }
}

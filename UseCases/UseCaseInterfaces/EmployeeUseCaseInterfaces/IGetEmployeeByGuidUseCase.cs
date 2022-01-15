using CoreBusiness;
using System.Threading.Tasks;

namespace UseCases.UseCaseInterfaces.EmployeeUseCaseInterfaces
{
    public interface IGetEmployeeByGuidUseCase
    {
        Task<Employee> Execute(string employeeGuid);
    }
}

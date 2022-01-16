using CoreBusiness;
using System.Threading.Tasks;

namespace UseCases.UseCaseInterfaces.EmployeeUseCaseInterfaces
{
    public interface IGetEmployeeByGuidUseCase
    {
        Employee Execute(string employeeGuid);
    }
}

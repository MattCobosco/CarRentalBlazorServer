using CoreBusiness;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace UseCases.UseCaseInterfaces.EmployeeUseCaseInterfaces
{
    public interface IViewEmployeesUseCase
    {
        Task<IEnumerable<Employee>> Execute();
    }
}

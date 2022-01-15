using System.Collections.Generic;
using System.Threading.Tasks;
using CoreBusiness;

namespace UseCases.UseCaseInterfaces.AssignmentUseCaseInterfaces
{
    public interface IViewAssignmentsUseCase
    {
        Task<IEnumerable<Assignment>> Execute();
    }
}
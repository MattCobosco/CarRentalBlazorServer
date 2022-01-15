using CoreBusiness;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace UseCases.UseCaseInterfaces.AssignmentUseCaseInterfaces
{
    public interface IViewAssignmentsUseCase
    {
        Task<IEnumerable<Assignment>> Execute();
    }
}
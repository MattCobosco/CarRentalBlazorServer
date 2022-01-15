using System.Collections.Generic;
using System.Threading.Tasks;
using CoreBusiness;

namespace UseCases.UseCaseInterfaces.AssignmentUseCaseInterfaces
{
    public interface IViewAssignmentsByAgentGuidUseCase
    {
        Task<IEnumerable<Assignment>> Execute(string agentGuid);
    }
}
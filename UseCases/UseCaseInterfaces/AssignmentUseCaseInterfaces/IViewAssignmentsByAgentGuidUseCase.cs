using CoreBusiness;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace UseCases.UseCaseInterfaces.AssignmentUseCaseInterfaces
{
    public interface IViewAssignmentsByAgentGuidUseCase
    {
        Task<IEnumerable<Assignment>> Execute(string agentGuid);
    }
}
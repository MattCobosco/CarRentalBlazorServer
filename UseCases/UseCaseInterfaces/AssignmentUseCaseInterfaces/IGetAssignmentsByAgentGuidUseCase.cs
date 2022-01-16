using CoreBusiness;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace UseCases.UseCaseInterfaces.AssignmentUseCaseInterfaces
{
    public interface IGetAssignmentsByAgentGuidUseCase
    {
        Task<IEnumerable<Assignment>> Execute(string agentGuid);
    }
}
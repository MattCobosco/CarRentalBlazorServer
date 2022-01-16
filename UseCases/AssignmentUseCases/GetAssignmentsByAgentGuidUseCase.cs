using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreBusiness;
using UseCases.DataStorePluginInterfaces;
using UseCases.UseCaseInterfaces.AssignmentUseCaseInterfaces;

namespace UseCases.AssignmentUseCases
{
    public class GetAssignmentsByAgentGuidUseCase : IGetAssignmentsByAgentGuidUseCase
    {
        private readonly IAssignmentRepository _assignmentRepository;

        public GetAssignmentsByAgentGuidUseCase(IAssignmentRepository assignmentRepository)
        {
            _assignmentRepository = assignmentRepository;
        }

        public Task<IEnumerable<Assignment>> Execute(string agentGuid)
        {
            return _assignmentRepository.GetAssignmentsByAgentGuid(agentGuid);
        }
    }
}

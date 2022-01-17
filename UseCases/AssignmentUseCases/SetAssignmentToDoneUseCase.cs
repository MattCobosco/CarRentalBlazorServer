using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;
using UseCases.UseCaseInterfaces.AssignmentUseCaseInterfaces;

namespace UseCases.AssignmentUseCases
{
    public class SetAssignmentToDoneUseCase : ISetAssignmentToDoneUseCase
    {
        private readonly IAssignmentRepository _assignmentRepository;

        public SetAssignmentToDoneUseCase(IAssignmentRepository assignmentRepository)
        {
            _assignmentRepository = assignmentRepository;
        }

        public Task Execute(string assignmentGuid)
        {
            return _assignmentRepository.SetAssignmentToDone(assignmentGuid);
        }
    }
}

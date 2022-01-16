using CoreBusiness;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;
using UseCases.UseCaseInterfaces.AssignmentUseCaseInterfaces;

namespace UseCases.AssignmentUseCases
{
    public class GetAssignmentByGuidUseCase : IGetAssignmentByGuidUseCase
    {
        private readonly IAssignmentRepository _assignmentRepository;

        public GetAssignmentByGuidUseCase(IAssignmentRepository assignmentRepository)
        {
            _assignmentRepository = assignmentRepository;
        }

        public Task<Assignment> Execute(string assignmentGuid)
        {
            return _assignmentRepository.GetAssignmentByGuidAsync(assignmentGuid);
        }
    }
}

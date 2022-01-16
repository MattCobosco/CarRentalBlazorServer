using CoreBusiness;
using UseCases.DataStorePluginInterfaces;
using UseCases.UseCaseInterfaces.AssignmentUseCaseInterfaces;

namespace UseCases.AssignmentUseCases
{
    public class AddEmployeeToAssignmentUseCase : IAddEmployeeToTheAssignmentUseCase
    {
        private readonly IAssignmentRepository _assignmentRepository;

        public AddEmployeeToAssignmentUseCase(IAssignmentRepository assignmentRepository)
        {
            _assignmentRepository = assignmentRepository;
        }

        public void Execute(Assignment assignment, string employeeGuid)
        {
            _assignmentRepository.AddEmployeeToTheAssignmentAsync(assignment, employeeGuid);
        }
    }
}

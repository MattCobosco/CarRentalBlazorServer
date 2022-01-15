using CoreBusiness;
using System.Collections.Generic;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;
using UseCases.UseCaseInterfaces.AssignmentUseCaseInterfaces;

namespace UseCases.AssignmentUseCases
{
    public class ViewAssignmentsUseCase : IViewAssignmentsUseCase
    {
        private readonly IAssignmentRepository _assignmentRepository;

        public ViewAssignmentsUseCase(IAssignmentRepository assignmentRepository)
        {
            _assignmentRepository = assignmentRepository;
        }

        public Task<IEnumerable<Assignment>> Execute()
        {
            return _assignmentRepository.GetAssignmentsAsync();
        }
    }
}

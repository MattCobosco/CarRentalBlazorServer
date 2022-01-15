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
    public class ViewAssignmentsUseCase : IViewAssignmentsUseCase
    {
        private IAssignmentRepository _assignmentRepository;

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

using CoreBusiness;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;
using UseCases.UseCaseInterfaces.AssignmentTypeUseCaseInterfaces;

namespace UseCases.AssignmentTypeUseCases
{
    public class GetAssignmentTypeByIdUseCase : IGetAssignmentTypeByIdUseCase
    {
        private readonly IAssignmentTypeRepository _assignmentTypeRepository;

        public GetAssignmentTypeByIdUseCase(IAssignmentTypeRepository assignmentTypeRepository)
        {
            _assignmentTypeRepository = assignmentTypeRepository;
        }

        public AssignmentType Execute(int assignmentTypeId)
        {
            return _assignmentTypeRepository.GetAssignmentTypeById(assignmentTypeId);
        }
    }
}

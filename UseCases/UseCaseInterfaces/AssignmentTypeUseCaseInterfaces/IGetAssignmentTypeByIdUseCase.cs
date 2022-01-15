using System.Threading.Tasks;
using CoreBusiness;

namespace UseCases.UseCaseInterfaces.AssignmentTypeUseCaseInterfaces
{
    public interface IGetAssignmentTypeByIdUseCase
    {
        AssignmentType Execute(int assignmentTypeId);
    }
}

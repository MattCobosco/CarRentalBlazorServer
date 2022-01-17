using System.Threading.Tasks;

namespace UseCases.UseCaseInterfaces.AssignmentUseCaseInterfaces
{
    public interface ISetAssignmentToDoneUseCase
    {
        Task Execute(string assignmentGuid);
    }
}

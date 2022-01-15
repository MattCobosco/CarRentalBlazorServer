using System.Threading.Tasks;
using CoreBusiness;

namespace UseCases.UseCaseInterfaces.AssignmentUseCaseInterfaces
{
    public interface IGetAssignmentByGuidUseCase
    {
        Task<Assignment> Execute(string assignmentGuid);
    }
}
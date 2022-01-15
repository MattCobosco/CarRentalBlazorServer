using CoreBusiness;
using System.Threading.Tasks;

namespace UseCases.UseCaseInterfaces.AssignmentUseCaseInterfaces
{
    public interface IGetAssignmentByGuidUseCase
    {
        Task<Assignment> Execute(string assignmentGuid);
    }
}
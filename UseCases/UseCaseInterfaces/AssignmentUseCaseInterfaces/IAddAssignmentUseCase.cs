using System.Threading.Tasks;
using CoreBusiness;

namespace UseCases.UseCaseInterfaces.AssignmentUseCaseInterfaces
{
    public interface IAddAssignmentUseCase
    {
        Task Execute(Assignment assignment);
    }
}
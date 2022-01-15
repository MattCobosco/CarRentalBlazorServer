using System.Threading.Tasks;

namespace UseCases.UseCaseInterfaces.AssignmentUseCaseInterfaces
{
    public interface IAddAssignmentFromReservationUseCase
    {
        Task Execute(string reservationGuid);
    }
}
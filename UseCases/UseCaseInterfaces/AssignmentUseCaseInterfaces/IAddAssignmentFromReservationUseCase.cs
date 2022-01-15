using System.Threading.Tasks;
using CoreBusiness;

namespace UseCases.UseCaseInterfaces.AssignmentUseCaseInterfaces
{
    public interface IAddAssignmentFromReservationUseCase
    {
        Task Execute(string reservationGuid);
    }
}
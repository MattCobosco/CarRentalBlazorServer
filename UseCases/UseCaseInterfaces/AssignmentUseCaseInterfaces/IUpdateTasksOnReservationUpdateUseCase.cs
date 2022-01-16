using CoreBusiness;
using System.Threading.Tasks;

namespace UseCases.UseCaseInterfaces.AssignmentUseCaseInterfaces
{
    public interface IUpdateTasksOnReservationUpdateUseCase
    {
        Task Execute(Reservation reservation);
    }
}

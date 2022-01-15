using CoreBusiness;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace UseCases.UseCaseInterfaces.ReservationUseCaseInterfaces
{
    public interface IViewConfirmedReservationsUseCase
    {
        Task<IEnumerable<Reservation>> Execute();
    }
}

using CoreBusiness;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace UseCases.UseCaseInterfaces.ReservationUseCaseInterfaces
{
    public interface IViewUnconfirmedReservationsUseCase
    {
        Task<IEnumerable<Reservation>> Execute();
    }
}

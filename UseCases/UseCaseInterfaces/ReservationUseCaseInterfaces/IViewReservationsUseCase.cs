using CoreBusiness;
using System.Collections.Generic;

namespace UseCases.UseCaseInterfaces.ReservationUseCaseInterfaces
{
    public interface IViewReservationsUseCase
    {
        IEnumerable<Reservation> Execute();
    }
}

using CoreBusiness;
using System.Collections.Generic;

namespace UseCases.UseCaseInterfaces.ReservationUseCaseInterfaces
{
    public interface IViewCustomerReservationsUseCase
    {
        IEnumerable<Reservation> Execute(string customerGuid);
    }
}

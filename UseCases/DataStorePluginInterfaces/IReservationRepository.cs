using CoreBusiness;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace UseCases.DataStorePluginInterfaces
{
    public interface IReservationRepository
    {
        void AddReservation(Reservation reservation);
        void ConfirmReservation(string reservationGuid);
        void DeleteReservation(string reservationGuid);
        void EditReservation(Reservation reservation);
        Reservation GetReservationByGuid(string reservationGuid);
        IEnumerable<Reservation> ViewCustomerReservations(string customerGuid);
        Task<IEnumerable<Reservation>> ViewConfirmedReservationsAsync();
        Task<IEnumerable<Reservation>> ViewUnconfirmedReservationsAsync();
    }
}

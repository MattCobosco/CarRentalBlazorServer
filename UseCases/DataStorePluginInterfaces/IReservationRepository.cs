using CoreBusiness;
using System;
using System.Collections.Generic;

namespace UseCases.DataStorePluginInterfaces
{
    public interface IReservationRepository
    {
        void AddReservation(Reservation reservation);
        void DeleteReservation(Guid reservationGuid);
        void EditReservation(Reservation reservation);
        Reservation GetReservationByGuid(Guid reservationGuid);
        IEnumerable<Reservation> GetReservations();
    }
}

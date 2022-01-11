using CoreBusiness;
using System;
using System.Collections.Generic;

namespace UseCases.DataStorePluginInterfaces
{
    public interface IReservationRepository
    {
        void AddReservation(Reservation reservation);
        void DeleteReservation(string reservationGuid);
        void EditReservation(Reservation reservation);
        Reservation GetReservationByGuid(string reservationGuid);
        IEnumerable<Reservation> GetReservations();
    }
}

using CoreBusiness;
using System;
using System.Collections.Generic;

namespace UseCases.DataStorePluginInterfaces
{
    public interface IReservationRepository
    {
        IEnumerable<Reservation> GetReservations();
        void AddReservation(Reservation reservation);
        Reservation GetReservationByGuid(Guid reservationGuid);
    }
}

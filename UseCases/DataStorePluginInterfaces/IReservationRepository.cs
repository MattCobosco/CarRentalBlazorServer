using CoreBusiness;
using System;
using System.Collections.Generic;

namespace UseCases.DataStorePluginInterfaces
{
    public interface IReservationRepository
    {
        IEnumerable<Reservation> GetReservations();
        void Save(int fleetVehicleId, DateTime startDateTime, DateTime endDateTime, int baseDailyPrice);
        Reservation GetReservationByGuid(Guid reservationGuid);
    }
}

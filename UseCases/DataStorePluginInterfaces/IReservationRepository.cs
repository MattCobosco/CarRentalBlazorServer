using CoreBusiness;
using System;
using System.Collections.Generic;

namespace UseCases.DataStorePluginInterfaces
{
    public interface IReservationRepository
    {
        IEnumerable<Reservation> GetReservations();
        void AddReservation(string fleetVehicleLicensePlate, DateTime startDateTime, DateTime endDateTime, string branchName, int price);
        Reservation GetReservationByGuid(Guid reservationGuid);
    }
}

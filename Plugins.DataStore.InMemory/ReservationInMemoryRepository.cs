using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using UseCases.DataStorePluginInterfaces;

namespace Plugins.DataStore.InMemory
{
    public class ReservationInMemoryRepository : IReservationRepository
    {
        private readonly List<Reservation> _reservations;

        public ReservationInMemoryRepository()
        {
            _reservations = new List<Reservation>
            {
                new() { ReservationGuid = Guid.NewGuid(), StartDateTime = DateTime.Now, EndDateTime = DateTime.Now.AddDays(2), Price = 69, StartBranchId = 2, EndBranchId = 1, FleetVehicleLicensePlate = "GD19791" }
            };
        }

        public IEnumerable<Reservation> GetReservations()
        {
            return _reservations;
        }

        public void AddReservation(Reservation reservation)
        {
            _reservations.Add(reservation);
        }

        public void EditReservation(Reservation reservation)
        {
            var reservationToEdit = GetReservationByGuid(reservation.ReservationGuid);

            if (reservationToEdit == null)
            {
                return;
            }

            reservationToEdit.StartDateTime = reservation.StartDateTime;
            reservationToEdit.EndDateTime = reservation.EndDateTime;
            reservationToEdit.Price = reservation.Price;
            reservationToEdit.StartBranchId = reservation.StartBranchId;
            reservationToEdit.EndBranchId = reservation.EndBranchId;
            reservationToEdit.FleetVehicleLicensePlate = reservation.FleetVehicleLicensePlate;
        }

        public Reservation GetReservationByGuid(Guid reservationGuid)
        {
            return _reservations.FirstOrDefault(x => x.ReservationGuid == reservationGuid);
        }

        public void DeleteReservation(Guid reservationGuid)
        {
            _reservations.Remove(GetReservationByGuid(reservationGuid));
        }
    }
}

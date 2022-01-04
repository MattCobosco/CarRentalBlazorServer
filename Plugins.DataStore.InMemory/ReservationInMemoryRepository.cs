using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using UseCases.DataStorePluginInterfaces;
using UseCases.FleetVehicleUseCases;
using UseCases.VehicleModelUseCases;

namespace Plugins.DataStore.InMemory
{
    public class ReservationInMemoryRepository : IReservationRepository
    {
        private readonly List<Reservation> _reservations;

        public ReservationInMemoryRepository()
        {
            _reservations = new List<Reservation>
            {
                new() {ReservationId = 1, ReservationGuid = Guid.NewGuid(), StartDateTime = DateTime.Now, EndDateTime = DateTime.Now.AddDays(2), Price = 69, BranchName = "Warszawa", FleetVehicleLicensePlate = "GD19791"}
            };
        }

        public IEnumerable<Reservation> GetReservations()
        {
            return _reservations;
        }

        public void AddReservation(string fleetVehicleLicensePlate, DateTime startDateTime, DateTime endDateTime, string branchName, int price)
        {
            int reservationId;

            if (_reservations is { Count: > 0 })
            {
                int maxId = _reservations.Max(x => x.ReservationId);
                reservationId = maxId + 1;
            }
            else
            {
                reservationId = 1;
            }

            _reservations.Add(new Reservation
            {
                ReservationId = reservationId,
                ReservationGuid = Guid.NewGuid(),
                FleetVehicleLicensePlate = fleetVehicleLicensePlate,
                BranchName = branchName,
                StartDateTime = startDateTime,
                EndDateTime = endDateTime,
                Price = price
            });
        }

        public Reservation GetReservationByGuid(Guid reservationGuid)
        {
            return _reservations.FirstOrDefault(x => x.ReservationGuid == reservationGuid);
        }

        //TODO: EditReservation, AddReservation methods
    }
}

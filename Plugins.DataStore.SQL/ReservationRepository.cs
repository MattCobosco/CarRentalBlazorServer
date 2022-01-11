using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using Plugins.DataStore.SQL.Data;
using UseCases.DataStorePluginInterfaces;

namespace Plugins.DataStore.SQL
{
    public class ReservationRepository : IReservationRepository
    {
        private readonly CarRentalContext _carRentalContext;

        public ReservationRepository(CarRentalContext carRentalContext)
        {
            _carRentalContext = carRentalContext;
        }

        public void AddReservation(Reservation reservation)
        {
            var transaction = _carRentalContext.Database.BeginTransaction();

            try
            {
                _carRentalContext.Add(reservation);
                _carRentalContext.SaveChanges();
                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                Console.WriteLine("Adding Reservation failed:");
                Console.WriteLine(ex.Message);
            }

        }

        public void DeleteReservation(Guid reservationGuid)
        {
            var transaction = _carRentalContext.Database.BeginTransaction();

            try
            {
                var reservation = GetReservationByGuid(reservationGuid);

                if(reservation == null)
                {
                    return;
                }

                _carRentalContext.Reservations.Remove(reservation);
                _carRentalContext.SaveChanges();
                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                Console.WriteLine("Deleting Reservation failed:");
                Console.WriteLine(ex.Message);
            }
        }

        public void EditReservation(Reservation reservation)
        {
            var transaction = _carRentalContext.Database.BeginTransaction();

            try
            {
                var reservationToEdit = GetReservationByGuid(reservation.ReservationGuid);

                reservationToEdit.StartDateTime = reservation.StartDateTime;
                reservationToEdit.EndDateTime = reservation.EndDateTime;
                reservationToEdit.Price = reservation.Price;
                reservationToEdit.StartBranchId = reservation.StartBranchId;
                reservationToEdit.EndBranch = reservation.EndBranch;
                reservationToEdit.FleetVehicleLicensePlate = reservation.FleetVehicleLicensePlate;

                _carRentalContext.SaveChanges();
                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                Console.WriteLine("Editing Reservation failed:");
                Console.WriteLine(ex.Message);
            }
        }

        public Reservation GetReservationByGuid(Guid reservationGuid)
        {
            var reservation = _carRentalContext.Reservations.Find(reservationGuid);

            if(reservation != null)
            {
                return reservation;
            }

            Console.WriteLine("Couldn't find the requested Reservation!");
            return null;
        }

        public IEnumerable<Reservation> GetReservations()
        {
            try
            {
                return _carRentalContext.Reservations.ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Getting Reservations failed:");
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}

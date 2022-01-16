using CoreBusiness;
using Microsoft.EntityFrameworkCore;
using Plugins.DataStore.SQL.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        public void ConfirmReservation(string reservationGuid)
        {
            var transaction = _carRentalContext.Database.BeginTransaction();

            try
            {
                var reservation = GetReservationByGuid(reservationGuid);

                if (reservation == null)
                {
                    return;
                }

                reservation.IsConfirmed = true;
                _carRentalContext.SaveChanges();
                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                Console.WriteLine("Confirming Reservation failed:");
                Console.WriteLine(ex.Message);
            }
        }

        public void DeleteReservation(string reservationGuid)
        {
            var transaction = _carRentalContext.Database.BeginTransaction();

            try
            {
                var reservation = GetReservationByGuid(reservationGuid);

                if (reservation == null)
                {
                    transaction.Rollback();
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
                reservationToEdit.EndBranchId = reservation.EndBranchId;
                reservationToEdit.VehicleModelId = reservation.VehicleModelId;
                reservationToEdit.FleetVehicleLicensePlate = reservation.FleetVehicleLicensePlate;
                reservationToEdit.CustomerGuid = reservation.CustomerGuid;
                reservationToEdit.StartAssignmentGuid = reservation.StartAssignmentGuid;
                reservationToEdit.EndAssignmentGuid = reservation.EndAssignmentGuid;

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

        public Reservation GetReservationByGuid(string reservationGuid)
        {
            var reservation = _carRentalContext.Reservations.Find(reservationGuid);

            if (reservation != null)
            {
                return reservation;
            }

            Console.WriteLine("Couldn't find the requested Reservation!");
            return null;
        }

        public IEnumerable<Reservation> ViewCustomerReservations(string customerGuid)
        {
            try
            {
                return _carRentalContext.Reservations
                    .Where(r => r.CustomerGuid == customerGuid);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Getting Customer Reservations failed:");
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public async Task<IEnumerable<Reservation>> ViewConfirmedReservationsAsync()
        {
            try
            {
                return await _carRentalContext.Reservations.Where(r => r.IsConfirmed == true).OrderBy(r => r.StartDateTime).ToListAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Getting Reservations failed:");
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public async Task<IEnumerable<Reservation>> ViewUnconfirmedReservationsAsync()
        {
            try
            {
                return await _carRentalContext.Reservations.Where(r => r.IsConfirmed == false).OrderBy(r => r.StartDateTime).ToListAsync();
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

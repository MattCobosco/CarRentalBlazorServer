using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using Plugins.DataStore.SQL.Data;
using UseCases.DataStorePluginInterfaces;

namespace Plugins.DataStore.SQL
{
    public class FleetVehicleRepository : IFleetVehicleRepository
    {
        private readonly CarRentalContext _carRentalContext;

        public FleetVehicleRepository(CarRentalContext carRentalContext)
        {
            _carRentalContext = carRentalContext;
        }

        public void AddFleetVehicle(FleetVehicle fleetVehicle)
        {
            var transaction = _carRentalContext.Database.BeginTransaction();

            if (_carRentalContext.FleetVehicles.Any(
                    x => x.FleetVehicleLicensePlate == fleetVehicle.FleetVehicleLicensePlate ||
                         x.Vin == fleetVehicle.Vin))
            {
                transaction.Rollback();
                Console.WriteLine("Such Fleet Vehicle already exists!");
                return;
            }

            try
            {
                _carRentalContext.Add(fleetVehicle);
                _carRentalContext.SaveChanges();
                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                Console.WriteLine("Adding Fleet Vehicle failed:");
                Console.WriteLine(ex.Message);
            }
        }

        public void DeleteFleetVehicle(string fleetVehicleLicensePlate)
        {
            var transaction = _carRentalContext.Database.BeginTransaction();

            try
            {
                var fleetVehicle = GetFleetVehicleByLicensePlate(fleetVehicleLicensePlate);

                if (fleetVehicle == null)
                {
                    return;
                }

                _carRentalContext.FleetVehicles.Remove(fleetVehicle);
                _carRentalContext.SaveChanges();
                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                Console.WriteLine("Deleting Fleet Vehicle failed:");
                Console.WriteLine(ex.Message);
            }
        }

        public void EditFleetVehicle(FleetVehicle fleetVehicle)
        {
            var transaction = _carRentalContext.Database.BeginTransaction();

            try
            {
                var fleetVehicleToEdit = GetFleetVehicleByLicensePlate(fleetVehicle.FleetVehicleLicensePlate);

                fleetVehicleToEdit.FleetVehicleLicensePlate = fleetVehicle.FleetVehicleLicensePlate;
                fleetVehicleToEdit.Odometer = fleetVehicle.Odometer;
                fleetVehicleToEdit.Vin = fleetVehicleToEdit.Vin;
                fleetVehicleToEdit.MaintenanceDate = fleetVehicleToEdit.MaintenanceDate;
                fleetVehicleToEdit.MaintenanceOdometer = fleetVehicle.MaintenanceOdometer;
                fleetVehicleToEdit.VehicleModelId = fleetVehicle.VehicleModelId;
                fleetVehicleToEdit.CurrentBranchId = fleetVehicle.CurrentBranchId;

                _carRentalContext.SaveChanges();
                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                Console.WriteLine("Editing Fleet Vehicle failed:");
                Console.WriteLine(ex.Message);
            }
        }

        public FleetVehicle GetFleetVehicleByLicensePlate(string fleetVehicleLicensePlate)
        {
            var fleetVehicle = _carRentalContext.FleetVehicles.Find(fleetVehicleLicensePlate);

            if (fleetVehicle != null)
            {
                return fleetVehicle;
            }

            Console.WriteLine("Couldn't find the requested Fleet Vehicle!");
            return null;
        }

        public IEnumerable<FleetVehicle> GetFleetVehicles()
        {
            try
            {
                return _carRentalContext.FleetVehicles.ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Getting Fleet Vehicles failed:");
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public IEnumerable<FleetVehicle> GetFleetVehicleMaintenanceDate()
        {
            DateTime listLimit = DateTime.Now.Add(new TimeSpan(14,0,0,0,0));

            var vehiclesForMaintenance =
                _carRentalContext.FleetVehicles.Where(f => f.MaintenanceDate < listLimit);

            return vehiclesForMaintenance?.ToList();
        }

        public IEnumerable<FleetVehicle> GetFleetVehicleMaintenanceOdometer()
        {
            var vehiclesForMaintenance =
                _carRentalContext.FleetVehicles.Where(f => f.MaintenanceOdometer - f.Odometer <= 1000).Select(f=>f);

            return vehiclesForMaintenance?.ToList();
        }
    }
}

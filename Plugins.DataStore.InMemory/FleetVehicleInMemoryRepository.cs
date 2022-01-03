using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using UseCases.DataStorePluginInterfaces;

namespace Plugins.DataStore.InMemory
{
    public class FleetVehicleInMemoryRepository : IFleetVehicleRepository
    {
        private readonly List<FleetVehicle> _fleetVehicles;

        public FleetVehicleInMemoryRepository()
        {
            _fleetVehicles = new List<FleetVehicle>
            {
                // Gdansk
                new() { FleetVehicleLicensePlate = "GD19791", Odometer = 345, Vin = "7A8NPS1E0XBJD3395", MaintenanceDate = DateTime.Today.AddYears(1), MaintenanceOdometer = 15000, DateAdded = DateTime.Today, CurrentBranchId = 1, ModelVehicleId = 1},
                new() { FleetVehicleLicensePlate = "GD23372", Odometer = 29200, Vin = "8AWT9NYH431RU0111", MaintenanceDate = DateTime.Today.AddMonths(1), MaintenanceOdometer = 30000, DateAdded = DateTime.Today.AddYears(-1), CurrentBranchId = 1, ModelVehicleId = 2},
                new() { FleetVehicleLicensePlate = "GD38400", Odometer = 5000, Vin = "VF68LSKN8ZTBW4537", MaintenanceDate = DateTime.Today.AddDays(14), MaintenanceOdometer = 15000, DateAdded = DateTime.Today.AddMonths(-3), CurrentBranchId = 1, ModelVehicleId = 3},

                // Warszawa
                new() { FleetVehicleLicensePlate = "WW81713", Odometer = 345, Vin = "99A5M70K4EB5H2412", MaintenanceDate = DateTime.Today.AddYears(1), MaintenanceOdometer = 15000, DateAdded = DateTime.Today, CurrentBranchId = 2, ModelVehicleId = 1},
                new() { FleetVehicleLicensePlate = "WW21759", Odometer = 29200, Vin = "YK1AA77X0TCNZ4856", MaintenanceDate = DateTime.Today.AddMonths(1), MaintenanceOdometer = 30000, DateAdded = DateTime.Today.AddYears(-1), CurrentBranchId = 2, ModelVehicleId = 2 },
                new() { FleetVehicleLicensePlate = "WW51732", Odometer = 5000, Vin = "ZGARLKYE2NJM55700", MaintenanceDate = DateTime.Today.AddDays(14), MaintenanceOdometer = 15000, DateAdded = DateTime.Today.AddMonths(-3), CurrentBranchId = 2, ModelVehicleId = 3 },
                    
                // Kraków - airport
                new() { FleetVehicleLicensePlate = "KR14805", Odometer = 345, Vin = "PR8T6WML9KN3V3570", MaintenanceDate = DateTime.Today.AddYears(1), MaintenanceOdometer = 15000, DateAdded = DateTime.Today, CurrentBranchId = 3, ModelVehicleId = 1 },
                new() { FleetVehicleLicensePlate = "KR14819", Odometer = 29200, Vin = "U5YX3MFX0CA4Y2611", MaintenanceDate = DateTime.Today.AddMonths(1), MaintenanceOdometer = 30000, DateAdded = DateTime.Today.AddYears(-1), CurrentBranchId = 3, ModelVehicleId = 2 },
                new() { FleetVehicleLicensePlate = "KR17430", Odometer = 5000, Vin = "SFDBSG9D24BNT5233", MaintenanceDate = DateTime.Today.AddDays(14), MaintenanceOdometer = 15000, DateAdded = DateTime.Today.AddMonths(-3), CurrentBranchId = 3, ModelVehicleId = 3 },

                // Krakow - city
                new() { FleetVehicleLicensePlate = "KR19676", Odometer = 345, Vin = "1NENUTEL5FABF3880", MaintenanceDate = DateTime.Today.AddYears(1), MaintenanceOdometer = 15000, DateAdded = DateTime.Today, CurrentBranchId = 4, ModelVehicleId = 1 },
                new() { FleetVehicleLicensePlate = "KR27495", Odometer = 29200, Vin = "2HMM5P9Z8F9JW7622", MaintenanceDate = DateTime.Today.AddMonths(1), MaintenanceOdometer = 30000, DateAdded = DateTime.Today.AddYears(-1), CurrentBranchId = 4,ModelVehicleId = 2 },
                new() { FleetVehicleLicensePlate = "KR37442", Odometer = 5000, Vin = "5N13BMGT1NLC85021", MaintenanceDate = DateTime.Today.AddDays(21), MaintenanceOdometer = 15000, DateAdded = DateTime.Today.AddMonths(-3), CurrentBranchId = 4, ModelVehicleId = 3 }
            };
        }

        public IEnumerable<FleetVehicle> GetFleetVehicles()
        {
            return _fleetVehicles;
        }

        public void AddFleetVehicle(FleetVehicle fleetVehicle)
        {
            if (_fleetVehicles.Any(x => x.Vin.Equals(fleetVehicle.Vin, StringComparison.OrdinalIgnoreCase)))
            {
                return;
            }
        }

        public void EditFleetVehicle(FleetVehicle fleetVehicle)
        {
            var fleetVehicleToEdit = GetFleetVehicleByLicensePlate(fleetVehicle.FleetVehicleLicensePlate);

            if (fleetVehicleToEdit == null) return;
            fleetVehicleToEdit.RegistrationPlate = fleetVehicle.RegistrationPlate;
            fleetVehicleToEdit.Odometer = fleetVehicle.Odometer;
            fleetVehicleToEdit.Vin = fleetVehicle.Vin;
            fleetVehicleToEdit.MaintenanceDate = fleetVehicle.MaintenanceDate;
            fleetVehicleToEdit.MaintenanceOdometer = fleetVehicle.MaintenanceOdometer;
            fleetVehicle.DateAdded = fleetVehicle.DateAdded;
            fleetVehicleToEdit.ModelVehicleId = fleetVehicle.ModelVehicleId;
            fleetVehicleToEdit.CurrentBranchId = fleetVehicle.CurrentBranchId;
        }

        public FleetVehicle GetFleetVehicleByLicensePlate(string fleetVehicleLicensePlate)
        {
            return _fleetVehicles?.FirstOrDefault(x => x.FleetVehicleLicensePlate == fleetVehicleLicensePlate);
        }

        public void DeleteFleetVehicle(string fleetVehicleLicensePlate)
        {
            _fleetVehicles?.Remove(GetFleetVehicleByLicensePlate(fleetVehicleLicensePlate));
        }
    }
}

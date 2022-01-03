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
                new() { FleetVehicleId = 1, RegistrationPlate = "GD19791", Odometer = 345, Vin = "7A8NPS1E0XBJD3395", MaintenanceDate = DateTime.Today.AddYears(1), MaintenanceOdometer = 15000, DateAdded = DateTime.Today, CurrentBranchId = 1 },
                new() { FleetVehicleId = 2, RegistrationPlate = "GD23372", Odometer = 29200, Vin = "8AWT9NYH431RU0111", MaintenanceDate = DateTime.Today.AddMonths(1), MaintenanceOdometer = 30000, DateAdded = DateTime.Today.AddYears(-1), CurrentBranchId = 1 },
                new() { FleetVehicleId = 3, RegistrationPlate = "GD38400", Odometer = 5000, Vin = "VF68LSKN8ZTBW4537", MaintenanceDate = DateTime.Today.AddDays(14), MaintenanceOdometer = 15000, DateAdded = DateTime.Today.AddMonths(-3), CurrentBranchId = 1 },

                // Warszawa
                new() { FleetVehicleId = 4, RegistrationPlate = "WW81713", Odometer = 345, Vin = "99A5M70K4EB5H2412", MaintenanceDate = DateTime.Today.AddYears(1), MaintenanceOdometer = 15000, DateAdded = DateTime.Today, CurrentBranchId = 2 },
                new() { FleetVehicleId = 5, RegistrationPlate = "WW21759", Odometer = 29200, Vin = "YK1AA77X0TCNZ4856", MaintenanceDate = DateTime.Today.AddMonths(1), MaintenanceOdometer = 30000, DateAdded = DateTime.Today.AddYears(-1), CurrentBranchId = 2 },
                new() { FleetVehicleId = 6, RegistrationPlate = "WW51732", Odometer = 5000, Vin = "ZGARLKYE2NJM55700", MaintenanceDate = DateTime.Today.AddDays(14), MaintenanceOdometer = 15000, DateAdded = DateTime.Today.AddMonths(-3), CurrentBranchId = 2 },
                    
                // Kraków - airport
                new() { FleetVehicleId = 7, RegistrationPlate = "KR14805", Odometer = 345, Vin = "PR8T6WML9KN3V3570", MaintenanceDate = DateTime.Today.AddYears(1), MaintenanceOdometer = 15000, DateAdded = DateTime.Today, CurrentBranchId = 3 },
                new() { FleetVehicleId = 8, RegistrationPlate = "KR14819", Odometer = 29200, Vin = "U5YX3MFX0CA4Y2611", MaintenanceDate = DateTime.Today.AddMonths(1), MaintenanceOdometer = 30000, DateAdded = DateTime.Today.AddYears(-1), CurrentBranchId = 3 },
                new() { FleetVehicleId = 9, RegistrationPlate = "KR17430", Odometer = 5000, Vin = "SFDBSG9D24BNT5233", MaintenanceDate = DateTime.Today.AddDays(14), MaintenanceOdometer = 15000, DateAdded = DateTime.Today.AddMonths(-3), CurrentBranchId = 3 },

                // Krakow - city
                new() {FleetVehicleId = 10, RegistrationPlate = "KR19676", Odometer = 345, Vin = "1NENUTEL5FABF3880", MaintenanceDate = DateTime.Today.AddYears(1), MaintenanceOdometer = 15000, DateAdded = DateTime.Today, CurrentBranchId = 4 },
                new() {FleetVehicleId = 11, RegistrationPlate = "KR27495", Odometer = 29200, Vin = "2HMM5P9Z8F9JW7622", MaintenanceDate = DateTime.Today.AddMonths(1), MaintenanceOdometer = 30000, DateAdded = DateTime.Today.AddYears(-1), CurrentBranchId = 4 },
                new() {FleetVehicleId = 12, RegistrationPlate = "KR37442", Odometer = 5000, Vin = "5N13BMGT1NLC85021", MaintenanceDate = DateTime.Today.AddDays(21), MaintenanceOdometer = 15000, DateAdded = DateTime.Today.AddMonths(-3), CurrentBranchId = 4 }
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

            if (_fleetVehicles is {Count: > 0})
            {
                var MaxId = _fleetVehicles.Max(x => x.ModelVehicleId);

                fleetVehicle.FleetVehicleId = MaxId + 1;
                _fleetVehicles.Add(fleetVehicle);
            }
            else
            {
                fleetVehicle.FleetVehicleId = 1;
            }
        }

        public void EditFleetVehicle(FleetVehicle fleetVehicle)
        {
            var fleetVehicleToEdit = GetFleetVehicleById(fleetVehicle.FleetVehicleId);

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

        public FleetVehicle GetFleetVehicleById(int fleetVehicleId)
        {
            return _fleetVehicles?.FirstOrDefault(x => x.FleetVehicleId == fleetVehicleId);
        }

        public void DeleteFleetVehicle(int fleetVehicleId)
        {
            _fleetVehicles?.Remove(GetFleetVehicleById(fleetVehicleId));
        }
    }
}

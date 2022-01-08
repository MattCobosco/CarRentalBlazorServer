using System;
using System.Collections.Generic;
using System.Linq;
using CoreBusiness;
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


        }

        public void DeleteFleetVehicle(string fleetVehicleLicensePlate)
        {
            throw new System.NotImplementedException();
        }

        public void EditFleetVehicle(FleetVehicle fleetVehicle)
        {
            throw new System.NotImplementedException();
        }

        public FleetVehicle GetFleetVehicleByLicensePlate(string fleetVehicleLicensePlate)
        {
            var fleetVehicle = _carRentalContext.FleetVehicles.Find(fleetVehicleLicensePlate);

            if(fleetVehicle != null)
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
    }
}

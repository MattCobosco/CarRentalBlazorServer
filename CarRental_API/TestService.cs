using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreBusiness;

namespace CarRental_API
{
    public class TestService
    {
        public bool IsThisCarInWarsaw(FleetVehicle fleetVehicle)
        {
            return fleetVehicle.CurrentBranchId == 2;
        }

        public bool DoesThisCarNeedsMaintenance(FleetVehicle fleetVehicle)
        {
            return fleetVehicle.MaintenanceOdometer < fleetVehicle.Odometer;
        }
    }
}

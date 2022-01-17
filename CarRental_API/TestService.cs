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
    }
}

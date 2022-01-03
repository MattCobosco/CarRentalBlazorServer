﻿using CoreBusiness;
using System.Collections.Generic;

namespace UseCases.DataStorePluginInterfaces
{
    public interface IFleetVehicleRepository
    {
        IEnumerable<FleetVehicle> GetFleetVehicles();
        void AddFleetVehicle(FleetVehicle fleetVehicle);
        void EditFleetVehicle(FleetVehicle fleetVehicle);
        FleetVehicle GetFleetVehicleById(int fleetVehicleId);
        void DeleteFleetVehicle(int fleetVehicleId);
    }
}
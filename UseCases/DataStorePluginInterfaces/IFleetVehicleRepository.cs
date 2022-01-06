using CoreBusiness;
using System.Collections.Generic;

namespace UseCases.DataStorePluginInterfaces
{
    public interface IFleetVehicleRepository
    {
        void AddFleetVehicle(FleetVehicle fleetVehicle);
        void DeleteFleetVehicle(string fleetVehicleId);
        void EditFleetVehicle(FleetVehicle fleetVehicle);
        FleetVehicle GetFleetVehicleByLicensePlate(string fleetVehicleId);
        IEnumerable<FleetVehicle> GetFleetVehicles();
    }
}

using CoreBusiness;
using System.Collections.Generic;

namespace UseCases.DataStorePluginInterfaces
{
    public interface IFleetVehicleRepository
    {
        void AddFleetVehicle(FleetVehicle fleetVehicle);
        void DeleteFleetVehicle(string fleetVehicleLicensePlate);
        void EditFleetVehicle(FleetVehicle fleetVehicle);
        FleetVehicle GetFleetVehicleByLicensePlate(string fleetVehicleLicensePlate);
        IEnumerable<FleetVehicle> GetFleetVehicles();
    }
}

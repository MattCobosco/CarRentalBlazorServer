using CoreBusiness;
using System.Collections.Generic;

namespace UseCases.DataStorePluginInterfaces
{
    public interface IVehicleBodyTypeRepository
    {
        void AddVehicleBodyType(VehicleBodyType vehicleBodyType);
        void DeleteVehicleBodyType(int vehicleBodyTypeId);
        void EditVehicleBodyType(VehicleBodyType vehicleBodyType);
        VehicleBodyType GetVehicleBodyTypeById(int vehicleBodyTypeId);
        IEnumerable<VehicleBodyType> ViewVehicleBodyTypes();
    }
}

using CoreBusiness;
using System.Collections.Generic;

namespace UseCases.DataStorePluginInterfaces
{
    public interface IVehicleModelRepository
    {
        IEnumerable<VehicleModel> GetVehicleModels();
        void AddVehicleModel(VehicleModel vehicleModel);
        void EditVehicleModel(VehicleModel vehicleModel);
        VehicleModel GetVehicleModelById(int vehicleModelId);
        void DeleteVehicleModel(int vehicleModelId);
    }
}

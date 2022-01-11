using CoreBusiness;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace UseCases.DataStorePluginInterfaces
{
    public interface IVehicleModelRepository
    {
        void AddVehicleModel(VehicleModel vehicleModel); 
        void DeleteVehicleModel(int vehicleModelId); 
        void EditVehicleModel(VehicleModel vehicleModel); 
        VehicleModel GetVehicleModelById(int vehicleModelId); 
        IEnumerable<VehicleModel> GetVehicleModels();
        Task<IEnumerable<VehicleModel>> GetVehicleModelsAsync();
    }
}

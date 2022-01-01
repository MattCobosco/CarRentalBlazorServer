using UseCases.DataStorePluginInterfaces;
using UseCases.UseCaseInterfaces.VehicleBodyTypeUseCaseInterfaces;

namespace UseCases.VehicleBodyTypeUseCases
{
    public class DeleteVehicleBodyTypeUseCase : IDeleteVehicleBodyTypeUseCase
    {
        private readonly IVehicleBodyTypeRepository _vehicleBodyTypeRepository;

        public DeleteVehicleBodyTypeUseCase(IVehicleBodyTypeRepository vehicleBodyTypeRepository)
        {
            _vehicleBodyTypeRepository = vehicleBodyTypeRepository;
        }

        public void Delete(int vehicleBodyTypeId)
        {
            _vehicleBodyTypeRepository.DeleteVehicleBodyType(vehicleBodyTypeId);
        }
    }
}

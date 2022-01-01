using CoreBusiness;
using UseCases.DataStorePluginInterfaces;
using UseCases.UseCaseInterfaces.VehicleBodyTypeUseCaseInterfaces;

namespace UseCases.VehicleBodyTypeUseCases
{
    public class AddVehicleBodyTypeUseCase : IAddVehicleBodyTypeUseCase
    {
        private readonly IVehicleBodyTypeRepository _vehicleBodyTypeRepository;

        public AddVehicleBodyTypeUseCase(IVehicleBodyTypeRepository vehicleBodyTypeRepository)
        {
            _vehicleBodyTypeRepository = vehicleBodyTypeRepository;
        }

        public void Execute(VehicleBodyType vehicleBodyType)
        {
            _vehicleBodyTypeRepository.AddVehicleBodyType(vehicleBodyType);
        }
    }
}

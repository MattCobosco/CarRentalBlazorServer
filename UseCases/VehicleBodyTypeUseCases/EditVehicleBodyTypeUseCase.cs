using CoreBusiness;
using UseCases.DataStorePluginInterfaces;
using UseCases.UseCaseInterfaces.VehicleBodyTypeUseCaseInterfaces;

namespace UseCases.VehicleBodyTypeUseCases
{
    public class EditVehicleBodyTypeUseCase : IEditVehicleBodyTypeUseCase
    {
        private readonly IVehicleBodyTypeRepository _vehicleBodyTypeRepository;

        public EditVehicleBodyTypeUseCase(IVehicleBodyTypeRepository vehicleBodyTypeRepository)
        {
            _vehicleBodyTypeRepository = vehicleBodyTypeRepository;
        }

        public void Execute(VehicleBodyType vehicleBodyType)
        {
            _vehicleBodyTypeRepository.EditVehicleBodyType(vehicleBodyType);
        }
    }
}

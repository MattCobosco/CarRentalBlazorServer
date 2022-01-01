using CoreBusiness;
using UseCases.DataStorePluginInterfaces;
using UseCases.UseCaseInterfaces.VehicleBodyTypeUseCaseInterfaces;

namespace UseCases.VehicleBodyTypeUseCases
{
    public class GetVehicleBodyTypeByIdUseCase : IGetVehicleBodyTypeByIdUseCase
    {
        private readonly IVehicleBodyTypeRepository _vehicleBodyTypeRepository;

        public GetVehicleBodyTypeByIdUseCase(IVehicleBodyTypeRepository vehicleBodyTypeRepository)
        {
            _vehicleBodyTypeRepository = vehicleBodyTypeRepository;
        }

        public VehicleBodyType Execute(int vehicleBodyTypeId)
        {
            return _vehicleBodyTypeRepository.GetVehicleBodyTypeById(vehicleBodyTypeId);
        }
    }
}

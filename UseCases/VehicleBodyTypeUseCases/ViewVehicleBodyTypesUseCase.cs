using CoreBusiness;
using System.Collections.Generic;
using UseCases.DataStorePluginInterfaces;
using UseCases.UseCaseInterfaces.VehicleBodyTypeUseCaseInterfaces;

namespace UseCases.VehicleBodyTypeUseCases
{
    public class ViewVehicleBodyTypesUseCase : IViewVehicleBodyTypesUseCase
    {
        private readonly IVehicleBodyTypeRepository _vehicleBodyTypeRepository;

        public ViewVehicleBodyTypesUseCase(IVehicleBodyTypeRepository vehicleBodyTypeRepository)
        {
            _vehicleBodyTypeRepository = vehicleBodyTypeRepository;
        }

        public IEnumerable<VehicleBodyType> Execute()
        {
            return _vehicleBodyTypeRepository.ViewVehicleBodyTypes();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreBusiness;
using UseCases.DataStorePluginInterfaces;
using UseCases.UseCaseInterfaces.VehicleModelUseCaseInterfaces;

namespace UseCases.VehicleModelUseCases
{
    public class GetVehicleModelByLicensePlateUseCase : IGetVehicleModelByLicensePlateUseCase
    {
        private readonly IVehicleModelRepository _vehicleModelRepository;
        private readonly IFleetVehicleRepository _fleetVehicleRepository;

        public GetVehicleModelByLicensePlateUseCase(
            IVehicleModelRepository vehicleModelRepository,
            IFleetVehicleRepository fleetVehicleRepository)
        {
            _vehicleModelRepository = vehicleModelRepository;
            _fleetVehicleRepository = fleetVehicleRepository;
        }

        public VehicleModel Execute(string licensePlate)
        {
            var fleetVehicle = _fleetVehicleRepository.GetFleetVehicleByLicensePlate(licensePlate);
            var vehicleModel = _vehicleModelRepository.GetVehicleModelById(fleetVehicle.ModelVehicleId);
            return vehicleModel;
        }
    }
}

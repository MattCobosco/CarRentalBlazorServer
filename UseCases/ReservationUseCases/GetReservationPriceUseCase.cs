using System;
using CoreBusiness;
using UseCases.DataStorePluginInterfaces;
using UseCases.UseCaseInterfaces.ReservationUseCaseInterfaces;

namespace UseCases.ReservationUseCases
{
    public class GetReservationPriceUseCase : IGetReservationPriceUseCase
    {
        private readonly IVehicleModelRepository _vehicleModelRepository;
        private readonly IFleetVehicleRepository _fleetVehicleRepository;

        public GetReservationPriceUseCase(
            IVehicleModelRepository vehicleModelRepository,
            IFleetVehicleRepository fleetVehicleRepository)
        {
            _vehicleModelRepository = vehicleModelRepository;
            _fleetVehicleRepository = fleetVehicleRepository;
        }

        // TODO: Fix price calculation => modelVehicle is null
        public int Execute(string licensePlate, DateTime startDate, DateTime endDate)
        {
            var numberOfDays = (int)(endDate - startDate).TotalDays;
            var fleetVehicle = _fleetVehicleRepository.GetFleetVehicleByLicensePlate(licensePlate);
            var vehicleModel = _vehicleModelRepository.GetVehicleModelById(fleetVehicle.ModelVehicleId);
            var basePrice = vehicleModel.BaseDailyPrice;
            return numberOfDays * basePrice;
        }
    }
}

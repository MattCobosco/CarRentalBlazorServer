using System;
using UseCases.UseCaseInterfaces.ReservationUseCaseInterfaces;
using UseCases.UseCaseInterfaces.VehicleModelUseCaseInterfaces;

namespace UseCases.ReservationUseCases
{
    public class GetReservationPriceUseCase : IGetReservationPriceUseCase
    {
        private readonly IGetVehicleModelByLicensePlateUseCase _getVehicleModelByLicensePlateUseCase;

        public GetReservationPriceUseCase(IGetVehicleModelByLicensePlateUseCase getVehicleModelByLicensePlateUseCase)
        {
            _getVehicleModelByLicensePlateUseCase = getVehicleModelByLicensePlateUseCase;
        }
        
        public int Execute(string licensePlate, DateTime startDate, DateTime endDate)
        {
            var numberOfDays = (int)(endDate - startDate).TotalDays;
            var vehicleModel = _getVehicleModelByLicensePlateUseCase.Execute(licensePlate);
            var basePrice = vehicleModel.BaseDailyPrice;
            return numberOfDays * basePrice;
        }
    }
}

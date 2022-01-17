using System;
using UseCases.UseCaseInterfaces.ReservationUseCaseInterfaces;
using UseCases.UseCaseInterfaces.VehicleModelUseCaseInterfaces;

namespace UseCases.ReservationUseCases
{
    public class GetReservationPriceUseCase : IGetReservationPriceUseCase
    {
        private readonly IGetVehicleModelByIdUseCase _getVehicleModelByIdUseCase;

        public GetReservationPriceUseCase(IGetVehicleModelByIdUseCase getVehicleModelByIdUseCase)
        {
            _getVehicleModelByIdUseCase = getVehicleModelByIdUseCase;
        }

        public int Execute(int vehicleModelId, DateTime startDate, DateTime endDate)
        {
            var numberOfDays = (int)Math.Ceiling((endDate - startDate).TotalDays);
            var vehicleModel = _getVehicleModelByIdUseCase.Execute(vehicleModelId);
            var basePrice = vehicleModel.BaseDailyPrice;
            return numberOfDays * basePrice;
        }
    }
}

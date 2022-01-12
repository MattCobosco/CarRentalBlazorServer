using System;

namespace UseCases.UseCaseInterfaces.ReservationUseCaseInterfaces
{
    public interface IGetReservationPriceUseCase
    {
        int Execute(int vehicleModelId, DateTime startDateTime, DateTime endDateTime);
    }
}

using System;

namespace UseCases.UseCaseInterfaces.ReservationUseCaseInterfaces
{
    public interface IGetReservationPriceUseCase
    {
        int Execute(string licensePlate, DateTime startDateTime, DateTime endDateTime);
    }
}

using System;

namespace UseCases.UseCaseInterfaces.ReservationUseCaseInterfaces
{
    public interface IAddReservationUseCase
    {
        void Execute(string fleetVehicleLicensePlate, DateTime startDateTime, DateTime endDateTime, string branchName, int price);
    }
}

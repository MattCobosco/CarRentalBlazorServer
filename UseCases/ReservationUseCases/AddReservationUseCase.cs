using System;
using UseCases.DataStorePluginInterfaces;
using UseCases.UseCaseInterfaces.ReservationUseCaseInterfaces;

namespace UseCases.ReservationUseCases
{
    public class AddReservationUseCase : IAddReservationUseCase
    {
        private readonly IReservationRepository _reservationRepository;

        public AddReservationUseCase(IReservationRepository reservationRepository)
        {
            _reservationRepository = reservationRepository;
        }

        public void Execute(string fleetVehicleLicensePlate, DateTime startDateTime, DateTime endDateTime, string branchName, int price)
        {
            _reservationRepository.AddReservation(fleetVehicleLicensePlate, startDateTime,  endDateTime, branchName, price);
        }
    }
}

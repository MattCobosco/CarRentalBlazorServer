using UseCases.DataStorePluginInterfaces;
using UseCases.UseCaseInterfaces.ReservationUseCaseInterfaces;

namespace UseCases.ReservationUseCases
{
    public class ConfirmReservationUseCase : IConfirmReservationUseCase
    {
        private readonly IReservationRepository _reservationRepository;

        public ConfirmReservationUseCase(IReservationRepository reservationRepository)
        {
            _reservationRepository = reservationRepository;
        }

        public void Confirm(string reservationGuid)
        {
            _reservationRepository.ConfirmReservation(reservationGuid);
        }
    }
}

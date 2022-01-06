using CoreBusiness;
using UseCases.DataStorePluginInterfaces;
using UseCases.UseCaseInterfaces.ReservationUseCaseInterfaces;

namespace UseCases.ReservationUseCases
{
    public class EditReservationUseCase : IEditReservationUseCase
    {
        private readonly IReservationRepository _reservationRepository;

        public EditReservationUseCase(IReservationRepository reservationRepository)
        {
            _reservationRepository = reservationRepository;
        }

        public void Execute(Reservation reservation)
        {
            _reservationRepository.EditReservation(reservation);
        }
    }
}

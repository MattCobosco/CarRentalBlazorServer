using UseCases.DataStorePluginInterfaces;
using UseCases.UseCaseInterfaces.ReservationUseCaseInterfaces;

namespace UseCases.ReservationUseCases
{
    public class DeleteReservationUseCase : IDeleteReservationUseCase
    {
        private readonly IReservationRepository _reservationRepository;

        public DeleteReservationUseCase(IReservationRepository reservationRepository)
        {
            _reservationRepository = reservationRepository;
        }

        public void Delete(string reservationGuid)
        {
            _reservationRepository.DeleteReservation(reservationGuid);
        }
    }
}

using CoreBusiness;
using UseCases.DataStorePluginInterfaces;
using UseCases.UseCaseInterfaces.ReservationUseCaseInterfaces;

namespace UseCases.ReservationUseCases
{
    public class GetReservationByGuidUseCase : IGetReservationByGuidUseCase
    {
        private readonly IReservationRepository _reservationRepository;

        public GetReservationByGuidUseCase(IReservationRepository reservationRepository)
        {
            _reservationRepository = reservationRepository;
        }

        public Reservation Execute(string reservationGuid)
        {
            return _reservationRepository.GetReservationByGuid(reservationGuid);
        }
    }
}

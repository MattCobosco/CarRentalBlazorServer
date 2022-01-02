using CoreBusiness;
using System;
using UseCases.DataStorePluginInterfaces;

namespace UseCases.ReservationUseCases
{
    public class GetReservationByGuidUseCase
    {
        private readonly IReservationRepository _reservationRepository;

        public GetReservationByGuidUseCase(IReservationRepository reservationRepository)
        {
            _reservationRepository = reservationRepository;
        }

        public Reservation Execute(Guid reservationGuid)
        {
            return _reservationRepository.GetReservationByGuid(reservationGuid);
        }
    }
}

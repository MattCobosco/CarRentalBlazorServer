using CoreBusiness;
using System.Collections.Generic;
using UseCases.DataStorePluginInterfaces;
using UseCases.UseCaseInterfaces.ReservationUseCaseInterfaces;

namespace UseCases.ReservationUseCases
{
    public class ViewReservationsUseCase : IViewReservationsUseCase
    {
        private readonly IReservationRepository _reservationRepository;

        public ViewReservationsUseCase(IReservationRepository reservationRepository)
        {
            _reservationRepository = reservationRepository;
        }

        public IEnumerable<Reservation> Execute()
        {
            return _reservationRepository.GetReservations();
        }
    }
}

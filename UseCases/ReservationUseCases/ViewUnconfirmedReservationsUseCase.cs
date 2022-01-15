using CoreBusiness;
using System.Collections.Generic;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;
using UseCases.UseCaseInterfaces.ReservationUseCaseInterfaces;

namespace UseCases.ReservationUseCases
{
    public class ViewUnconfirmedReservationsUseCase : IViewUnconfirmedReservationsUseCase
    {
        private readonly IReservationRepository _reservationRepository;

        public ViewUnconfirmedReservationsUseCase(IReservationRepository reservationRepository)
        {
            _reservationRepository = reservationRepository;
        }

        public Task<IEnumerable<Reservation>> Execute()
        {
            return _reservationRepository.GetUnconfirmedReservationsAsync();
        }
    }
}

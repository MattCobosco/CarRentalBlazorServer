using CoreBusiness;
using System.Collections.Generic;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;
using UseCases.UseCaseInterfaces.ReservationUseCaseInterfaces;

namespace UseCases.ReservationUseCases
{
    public class ViewConfirmedReservationsUseCase : IViewConfirmedReservationsUseCase
    {
        private readonly IReservationRepository _reservationRepository;

        public ViewConfirmedReservationsUseCase(IReservationRepository reservationRepository)
        {
            _reservationRepository = reservationRepository;
        }

        public async Task<IEnumerable<Reservation>> Execute()
        {
            return await _reservationRepository.ViewConfirmedReservationsAsync();
        }
    }
}

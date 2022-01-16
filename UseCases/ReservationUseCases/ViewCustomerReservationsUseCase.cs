using CoreBusiness;
using System.Collections.Generic;
using UseCases.DataStorePluginInterfaces;
using UseCases.UseCaseInterfaces.ReservationUseCaseInterfaces;

namespace UseCases.ReservationUseCases
{
    public class ViewCustomerReservationsUseCase : IViewCustomerReservationsUseCase
    {
        private readonly IReservationRepository _reservationRepository;

        public ViewCustomerReservationsUseCase(IReservationRepository reservationRepository)
        {
            _reservationRepository = reservationRepository;
        }

        public IEnumerable<Reservation> Execute(string customerGuid)
        {
            return _reservationRepository.ViewCustomerReservations(customerGuid);
        }
    }
}

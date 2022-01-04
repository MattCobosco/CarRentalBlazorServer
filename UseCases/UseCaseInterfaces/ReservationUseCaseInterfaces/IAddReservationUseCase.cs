using CoreBusiness;

namespace UseCases.UseCaseInterfaces.ReservationUseCaseInterfaces
{
    public interface IAddReservationUseCase
    {
        void Execute(Reservation reservation);
    }
}

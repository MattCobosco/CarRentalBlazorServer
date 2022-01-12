using CoreBusiness;

namespace UseCases.UseCaseInterfaces.ReservationUseCaseInterfaces
{
    public interface IGetReservationByGuidUseCase
    {
        Reservation Execute(string reservationGuid);
    }
}

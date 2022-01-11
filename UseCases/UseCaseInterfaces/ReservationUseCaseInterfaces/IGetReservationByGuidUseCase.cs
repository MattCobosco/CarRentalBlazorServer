using CoreBusiness;
using System;

namespace UseCases.UseCaseInterfaces.ReservationUseCaseInterfaces
{
    public interface IGetReservationByGuidUseCase
    {
        Reservation Execute(string reservationGuid);
    }
}

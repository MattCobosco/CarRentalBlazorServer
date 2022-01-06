using System;

namespace UseCases.UseCaseInterfaces.ReservationUseCaseInterfaces
{
    public interface IDeleteReservationUseCase
    {
        void Delete(Guid reservationGuid);
    }
}

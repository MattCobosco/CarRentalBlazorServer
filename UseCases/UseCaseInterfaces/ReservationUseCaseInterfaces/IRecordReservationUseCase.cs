using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCases.UseCaseInterfaces.ReservationUseCaseInterfaces
{
    public interface IRecordReservationUseCase
    {
        void Execute(int fleetVehicleId, DateTime startDateTime, DateTime endDateTime);
    }
}

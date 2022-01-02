using System;
using UseCases.DataStorePluginInterfaces;
using UseCases.UseCaseInterfaces.FleetVehicleUseCaseInterfaces;
using UseCases.UseCaseInterfaces.ReservationUseCaseInterfaces;
using UseCases.UseCaseInterfaces.VehicleModelUseCaseInterfaces;

namespace UseCases.ReservationUseCases
{
    public class RecordReservationUseCase : IRecordReservationUseCase
    {
        private readonly IReservationRepository _reservationRepository;
        private readonly IGetFleetVehicleByIdUseCase _getFleetVehicleByIdUseCase;
        private readonly IGetVehicleModelByIdUseCase _getVehicleModelByIdUseCase;

        public RecordReservationUseCase(
            IReservationRepository reservationRepository,
            IGetFleetVehicleByIdUseCase getFleetVehicleByIdUseCase,
            IGetVehicleModelByIdUseCase getVehicleModelByIdUseCase)
        {
            _reservationRepository = reservationRepository;
            _getFleetVehicleByIdUseCase = getFleetVehicleByIdUseCase;
            _getVehicleModelByIdUseCase = getVehicleModelByIdUseCase;
        }

        public void Execute(int fleetVehicleId, DateTime startDateTime, DateTime endDateTime)
        {
            var fleetVehicle = _getFleetVehicleByIdUseCase.Execute(fleetVehicleId);
            var modelVehicle = _getVehicleModelByIdUseCase.Execute(fleetVehicle.ModelVehicleId);
            _reservationRepository.Save(fleetVehicleId, startDateTime, endDateTime, modelVehicle.BaseDailyPrice);
        }
    }
}

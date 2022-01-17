using CoreBusiness;
using Microsoft.AspNetCore.Mvc;
using UseCases.UseCaseInterfaces.ReservationUseCaseInterfaces;

namespace CarRental_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetReservationByGuidController : ControllerBase
    {
        private readonly IGetReservationByGuidUseCase _getReservationByGuidUseCase;

        public GetReservationByGuidController(IGetReservationByGuidUseCase getReservationByGuidUseCase)
        {
            _getReservationByGuidUseCase = getReservationByGuidUseCase;
        }

        [HttpPost]
        public Reservation GetReservationByGuid([FromForm]string reservationGuid)
        {
            return _getReservationByGuidUseCase.Execute(reservationGuid);
        }
    }
}

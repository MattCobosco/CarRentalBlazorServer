using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;
using UseCases.UseCaseInterfaces.AssignmentUseCaseInterfaces;

namespace UseCases.AssignmentUseCases
{
    public class AddAssignmentFromReservationUseCase : IAddAssignmentFromReservationUseCase
    {
        private readonly IAssignmentRepository _assignmentRepository;

        public AddAssignmentFromReservationUseCase(IAssignmentRepository assignmentRepository)
        {
            _assignmentRepository = assignmentRepository;
        }

        public async Task Execute(string reservationGuid)
        {
            await _assignmentRepository.AddAssignmentFromReservationAsync(reservationGuid);
        }
    }
}

using CoreBusiness;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;
using UseCases.UseCaseInterfaces.AssignmentUseCaseInterfaces;

namespace UseCases.AssignmentUseCases
{
    public class UpdateTasksOnReservationUpdateUseCase : IUpdateTasksOnReservationUpdateUseCase
    {
        private readonly IAssignmentRepository _assignmentRepository;

        public UpdateTasksOnReservationUpdateUseCase(IAssignmentRepository assignmentRepository)
        {
            _assignmentRepository = assignmentRepository;
        }

        public Task Execute(Reservation reservation)
        {
            return _assignmentRepository.UpdateTasksOnReservationUpdateAsync(reservation);
        }
    }
}

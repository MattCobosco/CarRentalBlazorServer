using CoreBusiness;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace UseCases.DataStorePluginInterfaces
{
    public interface IAssignmentRepository
    {
        Task AddAssignmentFromReservationAsync(string reservationGuid);
        Task<Assignment> GetAssignmentByGuidAsync(string assignmentGuid);
        Task<IEnumerable<Assignment>> GetAssignmentsAsync();
        Task UpdateTasksOnReservationUpdateAsync(Reservation reservation);
        Task AddEmployeeToTheAssignmentAsync(Assignment assignment, string employeeGuid);
    }
}

using CoreBusiness;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace UseCases.DataStorePluginInterfaces
{
    public interface IAssignmentRepository
    {
        Task AddAssignmentFromReservationAsync(string reservationGuid);
        Task<IEnumerable<Assignment>> GetAssignmentsByAgentGuid(string agentGuid);
        Task<Assignment> GetAssignmentByGuidAsync(string assignmentGuid);
        Task UpdateTasksOnReservationUpdateAsync(Reservation reservation);
        Task AddEmployeeToTheAssignmentAsync(Assignment assignment, string employeeGuid);
        Task<IEnumerable<Assignment>> ViewAssignmentsAsync();
    }
}

using CoreBusiness;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace UseCases.DataStorePluginInterfaces
{
    public interface IAssignmentRepository
    {
        Task AddAssignmentFromReservationAsync(string reservationGuid);
        Task<IEnumerable<Assignment>> GetAssignmentsAsync();
    }
}

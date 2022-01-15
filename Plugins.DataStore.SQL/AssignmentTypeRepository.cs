using CoreBusiness;
using Plugins.DataStore.SQL.Data;
using UseCases.DataStorePluginInterfaces;

namespace Plugins.DataStore.SQL
{
    public class AssignmentTypeRepository : IAssignmentTypeRepository
    {
        private readonly CarRentalContext _carRentalContext;

        public AssignmentTypeRepository(CarRentalContext carRentalContext)
        {
            _carRentalContext = carRentalContext;
        }

        public AssignmentType GetAssignmentTypeById(int assignmentTypeId)
        {
            return _carRentalContext.AssignmentTypes.Find(assignmentTypeId);
        }
    }
}

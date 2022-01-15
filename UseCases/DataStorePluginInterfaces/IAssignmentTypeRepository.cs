using CoreBusiness;

namespace UseCases.DataStorePluginInterfaces
{
    public interface IAssignmentTypeRepository
    {
        AssignmentType GetAssignmentTypeById(int assignmentTypeId);
    }
}

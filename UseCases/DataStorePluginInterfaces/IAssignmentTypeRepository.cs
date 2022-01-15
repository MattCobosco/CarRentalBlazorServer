using CoreBusiness;
using System.Threading.Tasks;

namespace UseCases.DataStorePluginInterfaces
{
    public interface IAssignmentTypeRepository
    {
        AssignmentType GetAssignmentTypeById(int assignmentTypeId);
    }
}

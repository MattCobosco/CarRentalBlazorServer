using CoreBusiness;

namespace UseCases.UseCaseInterfaces.AssignmentUseCaseInterfaces
{
    public interface IAddEmployeeToTheAssignmentUseCase
    {
        void Execute(Assignment assignment, string employeeGuid);
    }
}

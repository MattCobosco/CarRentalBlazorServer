using CoreBusiness;

namespace UseCases.UseCaseInterfaces.CustomerUseCaseInterfaces
{
    public interface IGetCustomerByIdUseCase
    {
        Customer Execute(int customerId);
    }
}

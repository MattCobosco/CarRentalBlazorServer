using CoreBusiness;

namespace UseCases.UseCaseInterfaces.CustomerUseCaseInterfaces
{
    public interface IGetCustomerByIdUseCase
    {
        void Execute(Customer customer);
    }
}

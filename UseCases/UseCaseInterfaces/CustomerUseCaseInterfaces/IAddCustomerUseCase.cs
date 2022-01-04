using CoreBusiness;

namespace UseCases.UseCaseInterfaces.CustomerUseCaseInterfaces
{
    public interface IAddCustomerUseCase
    { 
        void Execute(Customer customer);
    }
}

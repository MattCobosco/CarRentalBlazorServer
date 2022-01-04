using CoreBusiness;
using UseCases.DataStorePluginInterfaces;
using UseCases.UseCaseInterfaces.CustomerUseCaseInterfaces;

namespace UseCases.CustomerUseCases
{
    public class AddCustomerUseCase : IAddCustomerUseCase
    {
        private readonly ICustomerRepository _customerRepository;

        public AddCustomerUseCase(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public void Execute(Customer customer)
        {
            _customerRepository.AddCustomer(customer);
        }
    }
}

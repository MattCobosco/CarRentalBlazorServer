using CoreBusiness;
using UseCases.DataStorePluginInterfaces;
using UseCases.UseCaseInterfaces.CustomerUseCaseInterfaces;

namespace UseCases.CustomerUseCases
{
    public class EditCustomerUseCase : IEditCustomerUseCase
    {
        private readonly ICustomerRepository _customerRepository;

        public EditCustomerUseCase(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public void Execute(Customer customer)
        {
            _customerRepository.EditCustomer(customer);
        }
    }
}

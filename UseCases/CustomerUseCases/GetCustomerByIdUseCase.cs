using CoreBusiness;
using UseCases.DataStorePluginInterfaces;
using UseCases.UseCaseInterfaces.CustomerUseCaseInterfaces;

namespace UseCases.CustomerUseCases
{
    public class GetCustomerByIdUseCase : IGetCustomerByIdUseCase
    {
        private readonly ICustomerRepository _customerRepository;

        public GetCustomerByIdUseCase(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public void Execute(Customer customer)
        {
            _customerRepository.EditCustomer(customer);
        }
    }
}

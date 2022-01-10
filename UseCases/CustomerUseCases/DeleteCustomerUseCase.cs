using UseCases.DataStorePluginInterfaces;
using UseCases.UseCaseInterfaces.CustomerUseCaseInterfaces;

namespace UseCases.CustomerUseCases
{
    public class DeleteCustomerUseCase : IDeleteCustomerUseCase
    {
        private readonly ICustomerRepository _customerRepository;

        public DeleteCustomerUseCase(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public void Delete(string customerGuid)
        {
            _customerRepository.DeleteCustomer(customerGuid);
        }
    }
}

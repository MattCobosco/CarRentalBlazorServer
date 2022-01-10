using CoreBusiness;
using UseCases.DataStorePluginInterfaces;
using UseCases.UseCaseInterfaces.CustomerUseCaseInterfaces;

namespace UseCases.CustomerUseCases
{
    public class GetCustomerByGuidUseCase : IGetCustomerByGuidUseCase
    {
        private readonly ICustomerRepository _customerRepository;

        public GetCustomerByGuidUseCase(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public Customer Execute(string customerGuid)
        {
            return _customerRepository.GetCustomerByGuid(customerGuid);
        }
    }
}

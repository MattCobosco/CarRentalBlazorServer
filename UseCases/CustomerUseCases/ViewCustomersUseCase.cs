using CoreBusiness;
using System.Collections.Generic;
using UseCases.DataStorePluginInterfaces;
using UseCases.UseCaseInterfaces.CustomerUseCaseInterfaces;

namespace UseCases.CustomerUseCases
{
    public class ViewCustomersUseCase : IViewCustomersUseCase
    {
        private readonly ICustomerRepository _customerRepository;

        public ViewCustomersUseCase(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public IEnumerable<Customer> Execute()
        {
            return _customerRepository.GetCustomers();
        }
    }
}

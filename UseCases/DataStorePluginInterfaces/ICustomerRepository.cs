using System.Collections.Generic;
using CoreBusiness;

namespace UseCases.DataStorePluginInterfaces
{
    public interface ICustomerRepository
    {
        IEnumerable<Customer> GetCustomers();
        void AddCustomer(Customer customer);
        void EditCustomer(Customer customer);
        Customer GetCustomerById(int customerId);
        public void DeleteCustomer(int customerId);
    }
}

using System.Collections.Generic;
using CoreBusiness;

namespace UseCases.DataStorePluginInterfaces
{
    public interface ICustomerRepository
    {
        void AddCustomer(Customer customer);
        void DeleteCustomer(int customerId);
        void EditCustomer(Customer customer);
        Customer GetCustomerById(int customerId);
        IEnumerable<Customer> GetCustomers();
    }
}

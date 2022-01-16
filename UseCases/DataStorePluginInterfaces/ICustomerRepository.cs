using CoreBusiness;
using System.Collections.Generic;

namespace UseCases.DataStorePluginInterfaces
{
    public interface ICustomerRepository
    {
        void AddCustomer(Customer customer);
        void DeleteCustomer(string customerGuid);
        void EditCustomer(Customer customer);
        Customer GetCustomerByGuid(string customerGuid);
        IEnumerable<Customer> ViewCustomers();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

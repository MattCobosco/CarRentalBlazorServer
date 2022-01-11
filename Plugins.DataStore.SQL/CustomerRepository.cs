using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using Plugins.DataStore.SQL.Data;
using UseCases.DataStorePluginInterfaces;

namespace Plugins.DataStore.SQL
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly CarRentalContext _carRentalContext;

        public CustomerRepository(CarRentalContext carRentalContext)
        {
            _carRentalContext = carRentalContext;
        }

        public void AddCustomer(Customer customer)
        {
            var transaction = _carRentalContext.Database.BeginTransaction();

            try
            {
                _carRentalContext.Add(customer);
                _carRentalContext.SaveChanges();
                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                Console.WriteLine("Adding Customer failed:");
                Console.WriteLine(ex.Message);
            }
        }

        public void DeleteCustomer(string customerGuid)
        {
            var transaction = _carRentalContext.Database.BeginTransaction();

            try
            {
                var customer = GetCustomerByGuid(customerGuid);

                if (customer == null)
                {
                    return;
                }

                _carRentalContext.Customers.Remove(customer);
                _carRentalContext.SaveChanges();
                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                Console.WriteLine("Deleting Customer failed:");
                Console.WriteLine(ex.Message);
            }
        }

        public void EditCustomer(Customer customer)
        {
            var transaction = _carRentalContext.Database.BeginTransaction();

            try
            {
                var customerToEdit = GetCustomerByGuid(customer.CustomerGuid);

                customerToEdit.FirstName = customer.FirstName;
                customerToEdit.LastName = customer.LastName;
                customerToEdit.ContactDetails = customer.ContactDetails;
                customerToEdit.Address = customer.Address;
                customerToEdit.PersonalDocumentNumber = customer.PersonalDocumentNumber;
                customerToEdit.DrivingLicenseNumber = customer.DrivingLicenseNumber;
                customerToEdit.Pesel = customer.Pesel;

                _carRentalContext.SaveChanges();
                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                Console.WriteLine("Editing Customer failed:");
                Console.WriteLine(ex.Message);
            }
        }

        public Customer GetCustomerByGuid(string customerGuid)
        {
            var customer = _carRentalContext.Customers.Find(customerGuid);

            if (customer != null)
            {
                return customer;
            }

            Console.WriteLine("Couldn't find the requested Customer!");
            return null;
        }

        public IEnumerable<Customer> GetCustomers()
        {
            try
            {
                return _carRentalContext.Customers.ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Getting Customers failed:");
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}

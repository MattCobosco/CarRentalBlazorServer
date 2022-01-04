﻿using System;
using System.Collections.Generic;
using System.Linq;
using CoreBusiness;
using UseCases.DataStorePluginInterfaces;

namespace Plugins.DataStore.InMemory
{
    public class CustomerInMemoryRepository : ICustomerRepository
    {
        private readonly List<Customer> _customers;

        public CustomerInMemoryRepository()
        {
            // Add default customers
            _customers = new List<Customer>
            {
                new()
                {
                    CustomerId = 1, FirstName = "Kamil", LastName = "Kozłowski", ContactDetails = "+48 534899994",
                    Address = "Pogodna 52/96 03-213 Sanok",
                    PersonalDocumentNumber = "MFG419865", DrivingLicenseNumber = "FHW32847", Pesel = "89112629714"
                },
                new()
                {
                    CustomerId = 2, FirstName = "Klaudia", LastName = "Makowska", ContactDetails = "+48 665701481",
                    Address = "Gdyńska 95A/41 77-347 Zamość",
                    PersonalDocumentNumber = "BCG815631", DrivingLicenseNumber = "ASD34532", Pesel = "92033048579"
                }
            };
        }

        public IEnumerable<Customer> GetCustomers()
        {
            return _customers;
        }

        public void AddCustomer(Customer customer)
        {
            if (_customers.Any(x => x.DrivingLicenseNumber.Equals(customer.DrivingLicenseNumber, StringComparison.OrdinalIgnoreCase)))
            {
                return;
            }

            if (_customers is { Count: > 0 })
            {
                var maxId = _customers.Max(x => x.CustomerId);

                customer.CustomerId = maxId + 1;
            }
            else
            {
                customer.CustomerId = 1;
            }

            _customers.Add(customer);
        }

        public void EditCustomer(Customer customer)
        {
            var customerToEdit = GetCustomerById(customer.CustomerId);

            if (customerToEdit == null) return;

            customerToEdit.FirstName = customer.FirstName;
            customerToEdit.LastName = customer.LastName;
            customerToEdit.ContactDetails = customer.ContactDetails;
            customerToEdit.Address = customer.Address;
            customer.PersonalDocumentNumber = customer.PersonalDocumentNumber;
            customerToEdit.DrivingLicenseNumber = customer.DrivingLicenseNumber;
            customerToEdit.Pesel = customer.Pesel;
        }

        public Customer GetCustomerById(int customerId)
        {
            return _customers.FirstOrDefault(x => x.CustomerId == customerId);
        }

        public void DeleteCustomer(int customerId)
        {
            _customers.Remove(GetCustomerById(customerId));
        }
    }
}

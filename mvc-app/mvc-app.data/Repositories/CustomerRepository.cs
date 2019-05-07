using mvc_app.data.DataStore;
using mvc_app.shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace mvc_app.data.Repositories
{
    public interface ICustomerRepository
    {
        IList<Customer> GetCustomers();
        Customer GetCustomerById(int id);
        void CreateCustomer(Customer customer);
    }
    public class CustomerRepository : ICustomerRepository
    {

        public void CreateCustomer(Customer customer)
        {
            CustomersData.Customers.Add(customer);
        }

        public Customer GetCustomerById(int id)
        {
            return CustomersData.Customers.SingleOrDefault(x => x.ID == id);
        }

        public IList<Customer> GetCustomers()
        {
            return CustomersData.Customers;
        }
    }
}

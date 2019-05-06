using System;
using System.Collections.Generic;
using System.Text;

namespace mvc_app.data.Repositories
{
    public interface ICustomerRepository
    {
        IList<Object> GetCustomers();
        Object GetCustomerById(int id);
        void CreateCustomer(Object customer);
    }
    public class CustomerRepository : ICustomerRepository
    {
        public void CreateCustomer(object customer)
        {
            throw new NotImplementedException();
        }

        public object GetCustomerById(int id)
        {
            throw new NotImplementedException();
        }

        public IList<object> GetCustomers()
        {
            throw new NotImplementedException();
        }
    }
}

using mvc_app.shared.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace mvc_app.data.DataStore
{
    public static class CustomersData
    {
        public static List<Customer> Customers = new List<Customer>
        {
            new Customer
            {
                ID = 1,
                Name = "JOHN SMITH",
                Address = "123 MAIN"
            },
            new Customer
            {
                ID = 1,
                Name = "JOHN SAMUELS",
                Address = "123 E MAIN"
            },
            new Customer
            {
                ID = 3,
                Name = "JOHN STEVENS",
                Address = "123 W MAIN"
            }
        };
    }
}

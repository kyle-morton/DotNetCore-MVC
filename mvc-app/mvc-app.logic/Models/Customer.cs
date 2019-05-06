using System;
using System.Collections.Generic;
using System.Text;

namespace mvc_app.logic.Models
{
    public class Customer : ModelBase
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public List<Order> Orders { get; set; }
    }
}

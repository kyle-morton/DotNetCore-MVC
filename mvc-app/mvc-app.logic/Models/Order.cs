using System;
using System.Collections.Generic;

namespace mvc_app.logic.Models
{
    public class Order : ModelBase
    {
        public DateTime CreateDate { get; set; }
        public string OrderNumber { get; set; }     
        public List<Item> Items { get; set; }
    }
}

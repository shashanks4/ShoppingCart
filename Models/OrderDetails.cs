using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingCart.Models
{

    public class OrderDetails
    {
        public class Detail
        {
            public int ProductID { get; set; }
            public string Product { get; set; }
            public decimal Price { get; set; }
            public int Quantity { get; set; }
        }
        public List<Detail> Details { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingCart.Models
{
    public class Products
    {
        public string ProductName { set; get; } = "";
        public string ProductId { get; set; } = "";
        public double Cost { get; set; } = 0;
    }
}
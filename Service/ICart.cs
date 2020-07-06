using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Service
{
    interface IOrder
    {
      

        List<Orders> Orders { get; set; }

        ProductService  GetOrders();
       ProductService RemoveOrder();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ShoppingCart.Models;
using ShoppingCart.Service;
using ShoppingCart.Controllers;
namespace ShoppingCart.Service
{
    public class Orders : IOrder
    {
        List<Orders> orders = new List<Orders>();

        //ProductService productService;
        //CustomerService customerService;
        //AuthenticationController authenticationController;
        //public Orders GetOrders(string id)
        //{
        //  if(au)
        //}
        public Orders GetOrders()
        {
            throw new NotImplementedException();
        }

        public ProductService RemoveOrder()
        {
            throw new NotImplementedException();
        }

        ProductService  GetOrders(string id)
        {
           
        }
    }
}
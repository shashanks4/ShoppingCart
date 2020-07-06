using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoppingCart.Models;

namespace ShoppingCart.Service
{
  public  interface IProductInterface
    {
        List<Products> GetProduct();
        Products GetProductById(string id);
        void AddProduct(Products product);
        Products UpdateProduct(string id, Products product);
        void DeleteProduct(string id);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ShoppingCart.Models;

namespace ShoppingCart.Service
{
    public class ProductService : IProductInterface
    {
        static List<Products> products = new List<Products>()
        {
            new Products { ProductId = "s12",ProductName = "Mask", Cost = 120 },
            new Products {ProductId = "M249",ProductName = "Sanitizer", Cost = 200  },
            new Products {ProductId = "M249",ProductName = "Sanitizer", Cost = 200  }
        };


        public List<Products> GetProduct()
        {
            return products;
        }

        public void AddProduct(Products product)
        { 
            products.Add(product);
        }

        public Products GetProductById(string id)
        {
            return products.Where(c => c.ProductId == id).FirstOrDefault();
        }

        public Products UpdateProduct(string id, Products product)
        {
            Products _product = products.Where(c => c.ProductId == id).FirstOrDefault();
            _product.ProductId = product.ProductId;
            _product.ProductName = product.ProductName;
            _product.Cost = product.Cost;



            return _product;
        }
        public void DeleteProduct(string id)
        {
            products.Remove(products.FirstOrDefault(c => c.ProductId == id));

        }


        
    }
}
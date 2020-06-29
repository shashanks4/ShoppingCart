using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ShoppingCart.Models;
namespace ShoppingCart.Controllers
{
    public class ProductsController : ApiController
    {
        List<Products> product = new List<Products>();
        public ProductsController()
        {
            product.Add(new Products { ProductName = "Mask", ProductId = "M164", Cost = 120 });
            product.Add( new Products { ProductName = "Sanitizer", ProductId = "M249", Cost = 500 });
            
        }
        // GET: api/Products
        public List<Products> Get()
        {
            return product ;
        }

        // GET: api/Products/5
        public Products Get(string id)
        {
            return product.Where(e=>e.ProductId == id).FirstOrDefault();
        }
        
        // POST: api/Products
        public void Post(Products items)
        
        {
            product.Add(items);
        }

        // PUT: api/Products/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Products/5
        public void Delete(int id)
        {
        }
    }
}

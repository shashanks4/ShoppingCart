using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ShoppingCart.Models;

namespace ShoppingCart.Controllers
{
    public class CustomerController : ApiController
    {
        List<Customer> customers = new List<Customer>();
        public CustomerController()
        {
            customers.Add(new Customer { CustomerName = "Shashank", Address = "Chickaballapur", PhoneNo = 12345667 });
            customers.Add(new Customer { CustomerName = "Samarth", Address = "Sri Lanka", PhoneNo = 098765312 });
            customers.Add(new Customer { CustomerName = "Abhi", Address = "Yelahanka", PhoneNo = 12345678 });
        }
        // GET: api/Customer
        public List<Customer> Get()
        {
            return customers;
        }

        // GET: api/Customer/5
        public Customer Get(string id)
        {
            return customers.Where(e => e.CustomerName == id).FirstOrDefault();
        }
        //[Route("api/Customer/CustomerValidation/{username :string/PhoneNo:int}")]
        //[HttpGet]
        //public List<Customer> CustomerValidation(string username, int phoneno)
        //{
        //    return  
        //}
        // POST: api/Customer
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Customer/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Customer/5
        public void Delete(int id)
        {
        }
    }
}

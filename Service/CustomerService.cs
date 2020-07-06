using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ShoppingCart.Models;

namespace ShoppingCart.Service
{
    public class CustomerService : ICustomerService
    {
       static List<Customer> customers = new List<Customer>()
     {
         new Customer { CustomerName = "Shashank", Address = "Chickaballapur", PhoneNo = 12345667,Password = "qwerty" },
         new Customer { CustomerName = "Samarth", Address = "Sri Lanka", PhoneNo = 098765312, Password = "asdf" },
        new Customer { CustomerName = "Abhi", Address = "Yelahanka", PhoneNo = 12345678 ,Password= "12344"}
     };
        public List<Customer> GetCustomers()
        {
            return customers;
        }
     
        public void AddCustomer(Customer customer)
        {
            customers.Add(customer);
        }

        public Customer GetCustomerByName(string name)
        {
            return customers.Where(c => c.CustomerName == name).FirstOrDefault();
        }

        public Customer Login(string username, string password)
        {
            foreach (var user in customers)
            {
                if ((username == user.CustomerName) && (password == user.Password))
                {
                    return user;
                }
            }
            return null;
        }

        public Customer UpdateCustomer(string name, Customer customer)
        {
            var data = customers.Where(c => c.CustomerName == name).FirstOrDefault();
            data.CustomerName = customer.CustomerName;
            data.Password = customer.Password;
         
            data.PhoneNo = customer.PhoneNo;
            data.Address = customer.Address;


            return data;
        }

        public void DeleteCustomer(string name)
        {
            customers.Remove(customers.FirstOrDefault(c => c.CustomerName == name));
        }

    }
}
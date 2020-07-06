using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoppingCart.Models; 

namespace ShoppingCart.Service
{
public    interface ICustomerService
    {
        List<Customer> GetCustomers();
        Customer GetCustomerByName(string name);
        void AddCustomer(Customer customer);
        Customer UpdateCustomer(string name, Customer customer);
        Customer Login(string username, string password);
        void DeleteCustomer(string name);
    }
}

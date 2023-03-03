using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D2OOP_Banking
{
    internal class Bank : Customer
    {
        public List<Customer> CustomerList;

        Customer customer = new Customer();

        public void CreateCustomer(string name, string password)
        {
            customer.Name = name;
            customer.Password = password;

            customer.AccountsList.Add(customer);
            
        }

        public void UpdateCustomer() 
        {
            

        }

        public void ShowCustomerDetails(Customer customer) 
        {
            Console.WriteLine(customer.AccountsList);
            Console.WriteLine(customer.Balance);
        }
    }
}

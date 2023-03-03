using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D2OOP_Banking
{
    internal class Data : Customer
    {
        public void FakeData() 
        {
            Customer customer = new Customer();

            customer.CreateAccount(1,"Ella", "Tieque4poo");
            customer.CreateAccount(2, "Mathilde", "Thai3eaz");
            customer.CreateAccount(3, "Simon", "iVahz6ey8v");


        }


    }
}

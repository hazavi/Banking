using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D2OOP_Banking
{
    internal class Customer : Account
    {
        public string Name { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;

        public List<Account> AccountsList { get; set; } = new List<Account>();

        public void CreateAccount(int accountnumber, string name, string password)
        {
            AccountNumber = accountnumber;
            Name = name;
            Password = password;
            AccountsList.Add(new Account {AccountNumber = accountnumber, Name = name});

        }

        public void AddToList(Customer customer)
        {
            AccountsList.Add(customer);
        }

        public void ShowAccountAndBalance()
        {
            Console.WriteLine("Accounts And Balance");
            foreach (var account in AccountsList) 
            {
                Console.WriteLine(account);            
            }
        }
    }
}

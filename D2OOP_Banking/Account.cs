using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D2OOP_Banking
{
    internal class Account 
    {
        public int AccountNumber { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Balance { get; set; }

        public void Deposit (decimal amount)
         {
            Balance += amount;
      
         }

        public void Withdraw(decimal amount)
        {
            Balance -= amount;
        }

        public void ShowBalance()
        {
            Console.WriteLine(Balance);
        }
    }

   
}

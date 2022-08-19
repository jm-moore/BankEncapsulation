using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    internal class BankAccount
    {
      private double balance = 0;

      public double Deposit(double money)
        {
            return balance += money; 
        }
        public double GetBalance()
        {
            return balance;
        }

        public double Withdrawal(double money)
        {
            return balance -= money;
        }

    }
}

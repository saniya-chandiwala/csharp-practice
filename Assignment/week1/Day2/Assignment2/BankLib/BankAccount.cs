using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLib
{
    #region
    /// <summary>
    /// class with methods to check, deposit and withdraw balance
    /// </summary>
    #endregion
    public class BankAccount
    {
        string CustomerName { get; set; }
        int AccountNumber { get; set; }
        static int balance = 2000;

        // returns balance in account
        public int CheckBalance()
        {
            return balance;
        }

        // adds balance
        public int Deposit(int amount)
        {
            return balance += amount;
        }

        // deducts specified amount 
        public int Withdraw(int amount)
        {
            if (balance > amount)
            {
                return balance -= amount;
            }

            else
            {
                return 0;
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagementSystemLib
{
    public class BankAccount
    {
        string customerName;
        int accountNumber;
        static int balance = 2000;

        // returns balance in account
        public int CheckBalance()
        {
            return balance;
        }

        // adds balance
        public int Deposit(int amount)
        {
            if (amount > 0)
            {
                return balance += amount;
            }
            else
            {
                return -1;
            }
        }

        // deducts specified amount 
        public int Withdraw(int amount)
        {
            if (balance > amount && amount >= 0)
            {
                return balance -= amount;
            }

            else
            {
                return -1;
            }
        }
    }
}

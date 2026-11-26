using System.Web;

namespace BankTransLib
{
    public delegate void TransactionDelegate(double amount);

    public class BankAccount
    {
        public int AccountNumber { get; set; }
        public string AccountHolderName { get; set; }
        public double Balance { get; set; }

        public void Deposit(double amount)
        {
            Balance = Balance + amount;
        }

        public void Withdraw(double amount)
        {
            if(Balance > amount)
            {
                Balance = Balance - amount;
            }
            else
            {
                HttpContext.Current.Response.Write("not enough balance");
            }            
        }
    }
}

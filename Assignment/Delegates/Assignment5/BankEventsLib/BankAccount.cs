//Event — Bank Account Low Balance

//A banking application should notify the customer whenever their account balance falls below ₹5,000.

//Create a class BankAccount with:

//AccountNumber
using System.Web;

namespace BankEventsLib
{
    public delegate void LowBalanceDel();

    public class BankAccount
    {
        public int AccountNumber { get; set; }
        public string AccountHolderName { get; set; }
        public double Balance { get; set; }

        // event
        public event LowBalanceDel LowBalance;

        public void Withdraw(double amount)
        {
            if (Balance > amount)
            {
                Balance = Balance - amount;

                if (Balance < 5000)
                {
                    //checking whether handler attach to event or not,if not in that case event is null
                    if (LowBalance != null)
                    {
                        //raising event
                        LowBalance();
                    }
                    else
                    {
                        HttpContext.Current.Response.Write("Event Handler not attach to event");
                    }
                }
                else
                {
                    HttpContext.Current.Response.Write("withdraw amount greater that balance");
                }
            }
        }
    }
}

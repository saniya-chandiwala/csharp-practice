namespace BankLib
{
    public class Account
    {
        readonly int accountNumber;
        public string CustomerName { get; set; }
        public string AccountType { get; set; }
        public double Balance { get; set; }

        public Account(int num, string name, string type, double bal)
        {
            accountNumber = num;
            CustomerName = name;
            AccountType = type;
            Balance = bal;
        }
    }
}

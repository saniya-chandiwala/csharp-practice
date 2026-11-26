namespace BankEventsLib
{
    public class AccountDetails
    {
        BankAccount[] accounts;

        public AccountDetails()
        {
            accounts = new BankAccount[]
            {
                new BankAccount() { AccountNumber = 101, AccountHolderName = "Saniya", Balance = 6000 },
                new BankAccount() { AccountNumber = 102, AccountHolderName = "Ayesha", Balance = 8000 },
                new BankAccount() { AccountNumber = 103, AccountHolderName = "Vanshika", Balance = 9000 }
            };
        }

        public BankAccount GetAccount(int num)
        {
            foreach (BankAccount acc in accounts)
            {
                if (acc.AccountNumber == num)
                {
                    return acc;
                }
            }
            return null;
        }
    }
}

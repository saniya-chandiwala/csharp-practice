namespace BankTransLib
{
    public class AccountDetails
    {
        BankAccount[] accounts;

        public AccountDetails()
        {
            accounts = new BankAccount[]
            {
                new BankAccount() { AccountNumber = 101, AccountHolderName = "Saniya", Balance = 16000 },
                new BankAccount() { AccountNumber = 102, AccountHolderName = "Ayesha", Balance = 10000 },
                new BankAccount() { AccountNumber = 103, AccountHolderName = "Vanshika", Balance = 5000 }
            };
        }

        public BankAccount GetAccount(int num)
        {
            foreach(BankAccount acc in accounts)
            {
                if(acc.AccountNumber == num)
                {
                    return acc;
                }
            }
            return null;
        }
    }
}

namespace BankLib
{
    #region
    /// <summary>
    /// class to verify account
    /// </summary>
    #endregion
    public class Verification
    {
        // verifying account based on account type and balance
        public Account AccountVerification(Account acc)
        {
            if (acc.AccountType == "Savings")
            {
                if (acc.Balance >= 1000)
                {
                    return acc;
                }
            }
            else if (acc.AccountType == "Salary")
            {
                if (acc.Balance >= 0)
                {
                    return acc;
                }
            }

            return null;
        }
    }
}

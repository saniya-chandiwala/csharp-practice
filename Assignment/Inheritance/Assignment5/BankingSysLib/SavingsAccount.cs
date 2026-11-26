namespace BankingSysLib
{
    public class SavingsAccount : BankAccount
    {
        public sealed override string CalculateInterest()
        {
            return "SavingsAccount class calculating intrest";
        }
    }
}


namespace BankAccountLib
{
    public class Account
    {
        static int count = 0;

        public int AccountCount()
        {
            return count++;
        }
    }
}

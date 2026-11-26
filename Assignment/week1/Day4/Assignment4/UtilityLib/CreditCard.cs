using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilityLib
{
    public static class CreditCard
    {
        public static double Rate(string cardType)
        {
            switch (cardType)
            {
                case "Silver":
                    return 0.01;

                case "Gold":
                    return 0.02;

                case "Platinum":
                    return 0.05;

                default:
                    return 0;
            }
        }

        public static double Cashback(string cardType, double amount)
        {
            return amount * Rate(cardType);
        }

        public static double FinalAmount(string cardType, double amount)
        {
            return amount - Cashback(cardType, amount);
        }
    }
}

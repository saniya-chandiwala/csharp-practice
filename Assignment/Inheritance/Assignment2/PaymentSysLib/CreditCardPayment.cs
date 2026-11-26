using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentSysLib
{
    public class CreditCardPayment : Payment
    {
        public override double MakePayment()
        {
            return Amount + (Amount * 0.02);
        }
    }
}

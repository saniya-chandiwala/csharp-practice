using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverterLib
{
    public static class CurrencyConv
    {
        static double usd = 95.23;

        public static double InrToUsd(double inr)
        {
            return inr / usd;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCalcLib
{
    public static class TaxCalc
    {
        static double gst = 0.18;

        public static double TaxAmount (double price)
        {
            return price * gst;
        }

        public static double TotalAmount(double price)
        {
            return price + TaxAmount(price);
        }
    }
}

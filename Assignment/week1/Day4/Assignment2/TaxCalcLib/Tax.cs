using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCalcLib
{
    public class Tax
    {
        static double gst = 0.18;

        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public double TaxAmount()
        {
            return TotalAmount() * gst;
        }

        public double TotalAmount()
        {
            return Price * Quantity;
        }

    }
}

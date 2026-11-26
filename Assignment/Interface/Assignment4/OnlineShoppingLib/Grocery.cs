using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShoppingLib
{
    public class Grocery : IDiscount
    {
        public double CalculateDiscount(double price)
        {
            return price * 0.02;
        }
    }
}

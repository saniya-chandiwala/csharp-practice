using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartLib
{
    #region
    /// <summary>
    /// class with methods to calculate total amount and and discount applicable
    /// </summary>
    #endregion
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        // method to calculate total amount (price * quantity)
        public double CalculateTotal()
        {
            return Price * Quantity;
        }

        // method to calculate applicable discount on price over 5000
        public double CalculateDiscount()
        {
            if (CalculateTotal() >= 5000)
            {
                return ((CalculateTotal() * 10)/100);
            }
            else
            {
                return CalculateTotal();
            }
        }
    }
}

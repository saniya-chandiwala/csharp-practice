using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartLib
{
    public class Product
    {
        string name;
        
        // method to calculate total amount
        public double CalculateTotal(double price,int quantity)
        {
            if (quantity > 0)
            {
                return price * quantity;
            }
            else
            {
                return 0;
            }
        }

        // method to calculate applicable discount
        public double CalculateDiscount(double price, int quantity)
        {
            if (CalculateTotal(price, quantity) > 5000)
            {
                return CalculateTotal(price, quantity) * 0.10;
            }
            else
            {
                return CalculateTotal(price, quantity);
            }
        }
    }
}

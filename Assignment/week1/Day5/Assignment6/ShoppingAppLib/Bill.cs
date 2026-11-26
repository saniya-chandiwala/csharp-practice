using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingAppLib
{
    public class Bill
    {
        public double BillTotal(CustomerDetails cd)
        {
            double price = 0;

            switch (cd.Product) {
                case "Apple":
                    price = 100;
                    break;

                case "Onion":
                    price = 200;
                    break;

                case "Brocolli":
                    price = 300;
                    break;
            }

            return price * cd.Quantity;
        }
    }
}

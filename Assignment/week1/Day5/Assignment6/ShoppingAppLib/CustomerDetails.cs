using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingAppLib
{
    public class CustomerDetails
    {
        public string Product { get; set; }
        public int Quantity { get; set; }

        public CustomerDetails(string product, int quantity)
        {
            Product = product;
            Quantity = quantity;
        }
    }
}

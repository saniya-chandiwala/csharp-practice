using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdsByCatLib
{
    public class ProductDetails
    {
        List<Product> products = new List<Product>()
        {
            new Product { Name= "Mobile", Category="Electronics" },
            new Product { Name= "Shirt", Category="Clothing" },
            new Product { Name= "Laptop", Category="Electronics" },
            new Product { Name= "Tablet", Category="Electronics" },
            new Product { Name= "Jeans", Category="Clothing" },
            new Product { Name= "Jacket", Category="Clothing" },
        };

        public List<Product> GetList()
        {
            return products;
        }
    }
}

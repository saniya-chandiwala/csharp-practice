using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartLib
{
    public class ProductDetails
    {
        static List<Product> products = new List<Product>()
        {
            new Product() { ProductId = 1, ProductName = "Chocolate", Price = 1000 },
            new Product() { ProductId = 2, ProductName = "Candy", Price = 700 },
            new Product() { ProductId = 3, ProductName = "Muffins", Price = 1100 },
            new Product() { ProductId = 4, ProductName = "Cookie", Price = 1200 }
        };

        List<Product> moreProducts = new List<Product>()
        {
            new Product() { ProductId = 5, ProductName = "Tiramisu", Price = 5000 },
            new Product() { ProductId = 6, ProductName = "Cake", Price = 2500 }
        };

        public List<Product> GetProductsList()
        {
            return products;
        }

        public List<Product> MoreProductsAdded()
        {
            return moreProducts;
        }
    }
}

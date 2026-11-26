using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdSortLib
{
    public class ProdDetails
    {
        List<Product> products = new List<Product>()
        {
            new Product { Id = 1, Name= "TV", Category="Electronics", Price=50000 },
            new Product { Id = 2, Name= "Tiramisu", Category="Food", Price=10000 },
            new Product { Id = 3, Name= "Microwave", Category="Electronics", Price=20000 },
            new Product { Id = 4, Name= "Fridge", Category="Electronics", Price=40000 },
            new Product { Id = 5, Name= "Air Fryer", Category="Electronics", Price=5000 },
        };

        public List<Product> GetListData()
        {
            return products;
        }
    }
}

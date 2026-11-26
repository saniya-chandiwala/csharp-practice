using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShoppingLib
{
    public class SampleData
    {
        public static List<Product> GetProducts()
        {
            return new List<Product>
            {
                new Product
                {
                    ProductId = 1,
                    ProductName = "iPhone 16",
                    Category = "Electronics",
                    Price = 75000,
                    Stock = 5
                },

                new Product
                {
                    ProductId = 2,
                    ProductName = "Samsung Galaxy",
                    Category = "Electronics",
                    Price = 55000,
                    Stock = 8
                },

                new Product
                {
                    ProductId = 3,
                    ProductName = "Dell Laptop",
                    Category = "Computers",
                    Price = 65000,
                    Stock = 12
                },

                new Product
                {
                    ProductId = 4,
                    ProductName = "HP Laptop",
                    Category = "Computers",
                    Price = 55000,
                    Stock = 6
                },

                new Product
                {
                    ProductId = 5,
                    ProductName = "Wireless Headphones",
                    Category = "Accessories",
                    Price = 2500,
                    Stock = 20
                },

                new Product
                {
                    ProductId = 6,
                    ProductName = "Smart Watch",
                    Category = "Accessories",
                    Price = 5000,
                    Stock = 15
                },

                new Product
                {
                    ProductId = 7,
                    ProductName = "iPhone Cover",
                    Category = "Accessories",
                    Price = 1200,
                    Stock = 30
                },

                new Product
                {
                    ProductId = 8,
                    ProductName = "Samsung Tablet",
                    Category = "Electronics",
                    Price = 25000,
                    Stock = 10
                }
            };
        }

        public static List<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer
                {
                    CustomerId = 101,
                    CustomerName = "Rahul",
                    City = "Mumbai"
                },

                new Customer
                {
                    CustomerId = 102,
                    CustomerName = "Priya",
                    City = "Pune"
                },

                new Customer
                {
                    CustomerId = 103,
                    CustomerName = "Amit",
                    City = "Mumbai"
                },

                new Customer
                {
                    CustomerId = 104,
                    CustomerName = "Neha",
                    City = "Delhi"
                },

                new Customer
                {
                    CustomerId = 105,
                    CustomerName = "Sneha",
                    City = "Mumbai"
                }
            };
        }

        public static List<Order> GetOrders()
        {
            return new List<Order>
            {
                new Order
                {
                    OrderId = 1001,
                    CustomerId = 101,
                    ProductId = 1,
                    Amount = 75000
                },

                new Order
                {
                    OrderId = 1002,
                    CustomerId = 102,
                    ProductId = 5,
                    Amount = 2500
                },

                new Order
                {
                    OrderId = 1003,
                    CustomerId = 103,
                    ProductId = 3,
                    Amount = 65000
                },

                new Order
                {
                    OrderId = 1004,
                    CustomerId = 101,
                    ProductId = 6,
                    Amount = 5000
                },

                new Order
                {
                    OrderId = 1005,
                    CustomerId = 105,
                    ProductId = 8,
                    Amount = 25000
                }
            };
        }

        public static List<ProductTag> GetProductTags()
        {
            return new List<ProductTag>
            {
                new ProductTag
                {
                    ProductId = 1,

                    Tags = new List<string>
                    {
                        "5G",
                        "Premium",
                        "Apple"
                    }
                },

                new ProductTag
                {
                    ProductId = 2,

                    Tags = new List<string>
                    {
                        "Android",
                        "5G"
                    }
                },

                new ProductTag
                {
                    ProductId = 3,

                    Tags = new List<string>
                    {
                        "Business",
                        "Laptop"
                    }
                },

                new ProductTag
                {
                    ProductId = 5,

                    Tags = new List<string>
                    {
                        "Wireless",
                        "Audio"
                    }
                }
            };
        }
    }
}
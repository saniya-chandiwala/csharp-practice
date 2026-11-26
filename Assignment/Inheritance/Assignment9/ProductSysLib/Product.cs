namespace ProductSysLib
{
    public class Product
    {
        public int ProductId { get; }
        public string ProductName { get; }
        public double ProductPrice { get; }

        public Product (int id, string name, double price)
        {
            ProductId = id;
            ProductName = name;
            ProductPrice = price;
        }

        public virtual string DisplayProduct()
        {
            return "Product Id: " + ProductId + "<br/>Product Name: " + ProductName + "<br/>Product Price: " + ProductPrice;
        }
    }
}

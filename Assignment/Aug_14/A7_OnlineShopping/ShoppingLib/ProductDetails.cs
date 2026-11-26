namespace ShoppingLib
{
    public class ProductDetails
    {
        Product[] products = { new Product(1, "Laptop", 70000), new Product(2, "TV", 60000), new Product(3, "Phone", 80000) };

        public Product GetProduct(int id)
        {
            foreach(Product p in products)
            {
                if(p.Id == id)
                {
                    return p;
                }
            }
            return null;      
        }
    }
}

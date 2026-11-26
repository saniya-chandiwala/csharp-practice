namespace ProductSysLib
{
    public class Clothing : Product
    {
        public Clothing(int id, string name, double price) : base(id, name, price)
        {

        }

        public new string DisplayProduct()
        {
            return "Clothing Product Id: " + ProductId + "<br/>Clothing Product Name: " + ProductName + "<br/>Clothing Product Price: " + ProductPrice;
        }
    }
}

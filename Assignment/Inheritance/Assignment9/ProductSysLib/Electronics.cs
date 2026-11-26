namespace ProductSysLib
{
    public class Electronics : Product
    {
        public Electronics(int id, string name, double price) : base(id, name, price)
        {

        }

        public override string DisplayProduct()
        {
            return " Product Id: " + ProductId + "<br/>Electronic Product Name: " + ProductName + "<br/>Electronic Product Price: " + ProductPrice;
        }
    }
}

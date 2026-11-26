namespace ShoppingAppLib
{
    public class Calculation
    {
        public double ApplyDiscount(Product p, double discountPercentage)
        {
            return p.ProductPrice - (p.ProductPrice * discountPercentage/100);
        }
    }
}

namespace ShoppingLib
{
    public class ExpenseCalc
    {
        public Product GetExpensiveProduct(Product p1, Product p2)
        {
            if (p1.Price > p2.Price)
            {
                return p1;
            }
            else if (p1.Price < p2.Price)
            {
                return p2;
            }
            return null;
        }
    }
}

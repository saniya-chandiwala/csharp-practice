//Online Shopping — Product Discount

//An e-commerce application provides discounts on different products.

//Create an interface IDiscount with:

//CalculateDiscount(double price)
//Create:

//Electronics
//Clothing
//Grocery
//Each category should calculate discount differently.

//Question: Write a C# program that accepts an IDiscount reference 
//    and calculates the discount without knowing the actual class.


namespace OnlineShoppingLib
{
    public interface IDiscount
    {
        double CalculateDiscount(double price);
    }
}

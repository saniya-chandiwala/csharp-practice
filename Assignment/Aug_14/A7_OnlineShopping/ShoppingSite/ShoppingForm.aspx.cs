using ShoppingLib;
using System;

public partial class ShoppingForm : System.Web.UI.Page
{
    Product p1;
    Product p2;
    Product higher;
    ProductDetails products;
    ExpenseCalc expense;

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnCompare_Click(object sender, EventArgs e)
    {
        try
        {
            products = new ProductDetails();
            expense = new ExpenseCalc();

            p1 = products.GetProduct(Convert.ToInt32(ddlProd1.SelectedValue));
            p2 = products.GetProduct(Convert.ToInt32(ddlProd2.SelectedValue));

            higher = expense.GetExpensiveProduct(p1, p2);

            if (higher != null)
            {
                lblResult.Text = "Product Id: " + higher.Id + "<br>Product Name: " + higher.Name + "<br>Product Price: " + higher.Price;
            }
            else
            {
                lblResult.Text = "equal value products";
            }
        }
        catch(Exception ex)
        {
            Response.Write(ex.Message);
        }
    }
}
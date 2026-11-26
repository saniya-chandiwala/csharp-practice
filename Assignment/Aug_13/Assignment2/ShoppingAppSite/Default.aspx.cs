using ShoppingAppLib;
using System;

public partial class _Default : System.Web.UI.Page
{
    Product product;
    Calculation calc;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnCalculate_Click(object sender, EventArgs e)
    {
        try
        {
            product = new Product() { ProductName = txtPrice.Text, ProductCategory = ddlCategory.SelectedValue, ProductPrice = Convert.ToDouble(txtPrice.Text) };
            calc = new Calculation();

            switch (ddlCategory.SelectedValue)
            {
                case "1":
                    lblDiscountedAmount.Text = "Discounted Amount: " + calc.ApplyDiscount(product, 0.5).ToString();
                    break;

                case "2":
                    lblDiscountedAmount.Text = "Discounted Amount: " + calc.ApplyDiscount(product, 0.10).ToString();
                    break;

                case "3":
                    lblDiscountedAmount.Text = "Discounted Amount: " + calc.ApplyDiscount(product, 0.15).ToString();
                    break;
            }
            lblOriginalAmount.Text = "Original Amount : " + product.ProductPrice;
        }
        catch(Exception ex)
        {
            Response.Write(ex.Message);
        }
    }
}
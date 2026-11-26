using ShoppingCartLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

#region
/// <summary>
/// class to find total and discounted amount of a product
/// </summary>
#endregion

public partial class CartForm : System.Web.UI.Page
{
    Product product = new Product();
    double price;
    int quantity;

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    // method to find total
    protected void btnTotal_Click(object sender, EventArgs e)
    {
        try
        {
            price = Convert.ToDouble(txtPrice.Text);
            quantity = Convert.ToInt32(txtQuantity.Text);
            double amount = product.CalculateTotal(price, quantity);
            lbTotalAmount.Text = amount.ToString();
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }
    }

    // method to find discount
    protected void btnDiscount_Click(object sender, EventArgs e)
    {
        try
        {
            price = Convert.ToDouble(txtPrice.Text);
            quantity = Convert.ToInt32(txtQuantity.Text);
            double discount = product.CalculateDiscount(price, quantity);
            lbDiscountedAmount.Text = discount.ToString();
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }

    }
}
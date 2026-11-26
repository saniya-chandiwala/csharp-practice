using System;
using OnlineShoppingLib;

public partial class _Default : System.Web.UI.Page
{
    IDiscount discount;
    double price;

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnCalc_Click(object sender, EventArgs e)
    {
        try
        {
            if (ddlCategory.SelectedValue == "Grocery")
            {
                discount = new Grocery();
            }
            else if (ddlCategory.SelectedValue == "Electronics")
            {
                discount = new Electronics();
            }
            else
            {
                discount = new Clothing();
            }

            price = Convert.ToDouble(txtPrice.Text);
            lblOutput.Text = discount.CalculateDiscount(price).ToString();
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }
    }
}
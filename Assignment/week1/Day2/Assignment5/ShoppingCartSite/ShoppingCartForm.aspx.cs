using ShoppingCartLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

#region
/// <summary>
/// class to to calculate the bill amount
/// </summary>
#endregion
public partial class ShoppingCartForm : System.Web.UI.Page
{
    Product prod;
    double price;
    int quantity;

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    // button to calculate results
    protected void btnTotal_Click(object sender, EventArgs e)
    {
        try
        {
            prod = new Product();
            price = Convert.ToDouble(txtPrice.Text);
            quantity = Convert.ToInt32(txtQuantity.Text);

            if (price > 0 && quantity > 0)
            {
                prod.Price = price;
                prod.Quantity = quantity;
                lbTotalAmount.Text = prod.CalculateTotal().ToString();
                lbDiscountedAmount.Text = prod.CalculateDiscount().ToString();
            }
            else
            {
                lbTotalAmount.Text = "invaild data entered";
                lbDiscountedAmount.Text = "invaild data entered";
            }


        }
        catch(Exception ex)
        {
            Response.Write(ex.Message);
        }

    }

}
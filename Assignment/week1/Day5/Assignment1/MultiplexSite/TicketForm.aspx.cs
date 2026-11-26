using MultiplexLib;
using System;

#region
/// <summary>
/// class to calculate ticket price
/// </summary>
#endregion
public partial class TicketForm : System.Web.UI.Page
{
    double price;
    int quantity;

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnPrice_Click(object sender, EventArgs e)
    {
        try
        {
            price = Convert.ToDouble(txtPrice.Text);
            quantity = Convert.ToInt32(txtQuantity.Text);

            if(price > 0 && quantity > 0)
            {
                lblSubTotal.Text = TicketCalculation.SubTotal(price, quantity).ToString();
                lblGst.Text = TicketCalculation.Gst(price, quantity).ToString();
                lblTotal.Text = TicketCalculation.Total(price, quantity).ToString();
                lblMessage.Text = " ";
            }
            else
            {
                lblMessage.Text = "invaild data entered";
            }
        }
        catch(Exception ex)
        {
            Response.Write(ex.Message);
        }
    }
}
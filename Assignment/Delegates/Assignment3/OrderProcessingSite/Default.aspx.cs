using System;
using OrderProcessingLib;

public partial class _Default : System.Web.UI.Page
{
    Order o;
    OrderHandler del;

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOrder_Click(object sender, EventArgs e)
    {
        try
        {
            o = new Order() { OrderId = 101, ProductName = "TV", Amount = 1000 };

            del = o.GenerateInvoice;
            del += o.SendConfirmationEmail;
            del += o.UpdateInventory;

            del();

            lblOutput.Text = o.Result;
        }
        catch(Exception ex)
        {
            Response.Write(ex.Message);
        }
    }
}
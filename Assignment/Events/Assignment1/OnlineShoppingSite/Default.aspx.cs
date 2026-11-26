using OnlineShoppingLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    Order order;

    int id;
    string name;
    double amt;

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnPlaceOrder_Click(object sender, EventArgs e)
    {
        try
        {
            id = Convert.ToInt32(txtId.Text);
            name = txtName.Text;
            amt = Convert.ToDouble(txtAmt.Text);

            if (id > 0 && !string.IsNullOrWhiteSpace(name) && amt > 0)
            {
                order = new Order()
                {
                    OrderId = id,
                    CustomerName = name,
                    Amount = amt
                };
                order.OrderPlacedEvent += new OrderPlacedDel(new Subscriber().DisplayOrder);
                order.PlaceOrder(order);
            }
            else
            {
                Response.Write("Invaild Data Entered");
            }
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }
    }

    
}

 class Subscriber
{
    public void DisplayOrder(Order order)
    {
        HttpContext.Current.Response.Write("Order " + order.OrderId + " placed successfully for " + order.CustomerName);
    }
}
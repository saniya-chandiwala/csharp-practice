using ShoppingAppLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class OrderForm : System.Web.UI.Page
{
    CustomerDetails customer;
    Bill b;
    double total;
    int quantity;

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnGenerateBill_Click(object sender, EventArgs e)
    {
        try
        {
            b = new Bill();

            if (chkApple.Checked)
            {
                quantity = Convert.ToInt32(txtApple.Text);

                customer = new CustomerDetails("Apple", quantity);

                total += b.BillTotal(customer);
            }

            if (chkOnion.Checked)
            {
                quantity = Convert.ToInt32(txtOnion.Text);

                customer = new CustomerDetails("Onion", quantity);

                total += b.BillTotal(customer);
            }

            if (chkBrocolli.Checked)
            {
                quantity = Convert.ToInt32(txtBrocolli.Text);

                customer = new CustomerDetails("Broccoli", quantity);

                total += b.BillTotal(customer);
            }

            lbBill.Text = "Total: " + total;
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }
    }
}
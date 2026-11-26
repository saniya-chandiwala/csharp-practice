using PaymentSysLib;
using System;

public partial class ShoppingForm : System.Web.UI.Page
{
    Payment p;
    double amt;
    int id;

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnCheckout_Click(object sender, EventArgs e)
    {
        try
        {
            amt = Convert.ToDouble(txtAmount.Text);
            id = Convert.ToInt32(txtId.Text);
            
            if(amt > 0 && id >= 0)
            {
                switch (ddlPayment.SelectedValue)
                {
                    case "Credit Card":
                        p = new CreditCardPayment();
                        break;

                    case "Net Banking":
                        p = new NetBankingPayment();
                        break;

                    case "UPI":
                        p = new UPIPayment();
                        break;
                }

                p.Amount = amt;
                p.TransactionId = id;

                p.Amount = p.MakePayment();

                lblBill.Text = p.GenerateReceipt();
            }
            else
            {
                lblBill.Text = "invalid data entered";
            }
        }
        catch(Exception exp)
        {
            Response.Write(exp.Message);
        }
    }
}
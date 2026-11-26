using System;
using BankEventsLib;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    static BankAccount bank;
    AccountDetails acc;

    int num;
    double amt;

    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void ddlAccounts_SelectedIndexChanged(object sender, EventArgs e)
    {
        acc = new AccountDetails();
        bank = new BankAccount();
        num = Convert.ToInt32(ddlAccounts.SelectedValue);

        bank = acc.GetAccount(num);
        lblDetails.Text = "Account Holder Name: " + bank.AccountHolderName + "<br/>Balance: " + bank.Balance;
    }

    protected void btnWithdraw_Click(object sender, EventArgs e)
    {
        try
        {
            amt = Convert.ToDouble(txtAmount.Text);

            if (amt > 0)
            {
                //attaching handler to event through delegate
                bank.LowBalance += new LowBalanceDel(new Subscriber().WarningMethod);
                bank.Withdraw(amt);

                lblOutput.Text = bank.Balance.ToString();
            }
            else
            {
                lblOutput.Text = "invaild amt entered";
            }
        }
        catch(Exception ex)
        {
            Response.Write(ex.Message);
        }        
    }

    class Subscriber
    {
        // handler
        public void WarningMethod()
        {
            HttpContext.Current.Response.Write("Warning: Your account balance is below ₹5,000.");
        }
    }
}
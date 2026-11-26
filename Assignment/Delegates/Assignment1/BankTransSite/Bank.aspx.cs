using BankTransLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Bank : System.Web.UI.Page
{
    static BankAccount account;
    AccountDetails details;
    TransactionDelegate del;
        
    int num;
    double amt;

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void ddlAccounts_SelectedIndexChanged(object sender, EventArgs e)
    {
        details = new AccountDetails();
        num = Convert.ToInt32(ddlAccounts.SelectedValue);

        account = details.GetAccount(num);
        lblDetails.Text = "Account Holder Name: " + account.AccountHolderName + "<br/>Balance: " + account.Balance;
    }

    protected void btnPerform_Click(object sender, EventArgs e)
    {
        try
        {
            amt = Convert.ToDouble(txtAmount.Text);

            if(amt > 0)
            {
                if (rdoDeposit.Checked)
                {
                    del = account.Deposit;
                }
                else
                {
                    del = account.Withdraw;
                }

                del(amt);
                lblOutput.Text = account.Balance.ToString();
            }            
            else
            {
                lblOutput.Text = "invalid amount entered";
            }
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }
        
    }
}

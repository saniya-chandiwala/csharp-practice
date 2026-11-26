using BankLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

#region
/// <summary>
/// class to  manage customer balance
/// </summary>
#endregion
public partial class BankForm : System.Web.UI.Page
{
    int depositAmount, withdrawAmount, amount;
    BankAccount account;

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    // button to check balance
    protected void btnCheckBalance_Click(object sender, EventArgs e)
    {
        try
        {
            account = new BankAccount();
            lbCheckBalance.Text = account.CheckBalance().ToString();
        }
        catch (Exception exp)
        {
            Response.Write(exp.Message);
        }
    }

    // button to deposit amount
    protected void btnDeposit_Click(object sender, EventArgs e)
    {
        try
        {
            account = new BankAccount();
            depositAmount = Convert.ToInt32(txtAmount.Text);

            if (depositAmount > 0) {
                lbCheckBalance.Text = account.Deposit(depositAmount).ToString();
            }
            else
            {
                lbCheckBalance.Text = "Invalid Data";
            }
            
        }
        catch (Exception exp)
        {
            Response.Write(exp.Message);
        }
    }

    // button to withdraw amount
    protected void btnWithdraw_Click(object sender, EventArgs e)
    {
        try
        {
            account = new BankAccount();
            withdrawAmount = Convert.ToInt32(txtAmount.Text);
            if(withdrawAmount > 0)
            {
                lbCheckBalance.Text = account.Withdraw(withdrawAmount).ToString();
            }
            else
            {
                lbCheckBalance.Text = "Invaild Amount";
            }
        }
        catch (Exception exp)
        {
            Response.Write(exp.Message);
        }
    }

}
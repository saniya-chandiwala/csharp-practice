using BankLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

#region
/// <summary>
/// class for bank management system with deposit, withdraw and check balance methods.
/// </summary>
#endregion
public partial class BankForm : System.Web.UI.Page
{
    int depositAmount, withdrawAmount, checkBalance, amount;
    BankAccount account = new BankAccount();

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnCheckBalance_Click(object sender, EventArgs e)
    {
        try
        {
            amount = account.CheckBalance();
            lbCheckBalance.Text = amount.ToString();
        }
        catch (Exception exp)
        {
            Response.Write(exp.Message);
        }
    }

    protected void btnDeposit_Click(object sender, EventArgs e)
    {
        try
        {
            depositAmount = Convert.ToInt32(txtDepositAmount.Text);
            amount = account.Deposit(depositAmount);

            lbCheckBalance.Text = amount.ToString();
        }
        catch (Exception exp)
        {
            Response.Write(exp.Message);
        }
    }

    protected void btnWithdraw_Click(object sender, EventArgs e)
    {
        try
        {
            withdrawAmount = Convert.ToInt32(txtWithdrawAmount.Text);
            amount = account.Withdraw(withdrawAmount);
            lbCheckBalance.Text = amount.ToString();
        }
        catch (Exception exp)
        {
            Response.Write(exp.Message);
        }
    }
}
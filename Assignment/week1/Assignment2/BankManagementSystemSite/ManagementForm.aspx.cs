using BankManagementSystemLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

#region
/// <summary>
/// form to check an accounts balance deposit and withdraw specified amount
/// </summary>
#endregion

public partial class ManagementForm : System.Web.UI.Page
{
    int depositAmount, withdrawAmount, checkBalance, amount;
    BankAccount account = new BankAccount();

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    // check balance code
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

    // deposit balance code
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

    // withdraw balance code
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
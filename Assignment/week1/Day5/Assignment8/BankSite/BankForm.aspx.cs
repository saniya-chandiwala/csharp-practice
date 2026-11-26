using BankLib;
using System;

public partial class BankForm : System.Web.UI.Page
{
    Account acc;
    Verification v;
    int num;
    string name, type;
    double bal;

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnCreate_Click(object sender, EventArgs e)
    {
        try {
            bal = Convert.ToDouble(txtBalance.Text);
            num = Convert.ToInt32(txtNum.Text);
            name = txtName.Text;
            type = ddlAccountType.SelectedValue;

            acc = new Account(num, name, type, bal);
            v = new Verification();

            acc = v.AccountVerification(acc);

            if(acc != null)
            {
                lblVerifiedDetails.Text = "Verified Successfully" + 
                    "<br>Account Number: " + num +
                    "<br>Customer Name: " + acc.CustomerName +
                    "<br>Account Type: " + acc.AccountType +
                    "<br> Amount Deposited: " + acc.Balance;
                lblError.Text = " ";
            }
            else
            {
                lblError.Text = "Verification failed";
                lblVerifiedDetails.Text = " ";
            }
        }
        catch(Exception ex)
        {
            Response.Write(ex.Message);
        }
        }
}
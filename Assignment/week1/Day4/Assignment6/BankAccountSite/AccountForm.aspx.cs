using BankAccountLib;
using System;

public partial class AccountForm : System.Web.UI.Page
{
    Account acc;

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnCreate_Click(object sender, EventArgs e)
    {
        acc = new Account();
        lblCount.Text = acc.AccountCount().ToString();
    }
}
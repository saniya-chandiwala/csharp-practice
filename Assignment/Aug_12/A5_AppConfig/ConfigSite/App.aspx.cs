using System;
using ConfigLib;

public partial class App : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnDetails_Click(object sender, EventArgs e)
    {
        lblName.Text = Config.bankName;
        lblBal.Text = Config.minBal.ToString();
        lblWithdrawal.Text = Config.maxLimit.ToString();
        lblVer.Text = Config.appVersion.ToString();
    }
}
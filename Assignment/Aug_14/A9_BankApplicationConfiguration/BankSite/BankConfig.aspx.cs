using AppConfig;
using System;

public partial class BankConfig : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnDisplay_Click(object sender, EventArgs e)
    {
        lblDisplay.Text = BankConfiguration.DisplayConfiguration();
    }
}
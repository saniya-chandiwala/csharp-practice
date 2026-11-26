using EMSLib;
using System;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnDisplay_Click(object sender, EventArgs e)
    {
        try
        {
            lblConfig.Text = Employee.DisplayConfiguration();
        }
        catch(Exception ex)
        {
            Response.Write(ex.Message);
        }
    }
}
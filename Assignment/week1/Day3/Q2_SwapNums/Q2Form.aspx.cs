using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Q2Form : System.Web.UI.Page
{
    int a, b, temp;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSwap_Click(object sender, EventArgs e)
    {
        try
        {
            a = Convert.ToInt32(txtValueA.Text);
            b = Convert.ToInt32(txtValueB.Text);

            temp = a;
            a = b;
            b = temp;

            lbAfterSwapA.Text = a.ToString();
            lbAfterSwapB.Text = b.ToString();

        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }
    }
}
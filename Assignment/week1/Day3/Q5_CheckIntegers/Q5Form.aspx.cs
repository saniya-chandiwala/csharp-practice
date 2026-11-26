using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Q5Form : System.Web.UI.Page
{
    int first, second;

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnCheck_Click(object sender, EventArgs e)
    {
        try
        {
            first = Convert.ToInt32(txtFirst.Text);
            second = Convert.ToInt32(txtSecond.Text);

            if((first>=0 && second<=0) || (second>=0 && first <= 0))
            {
                lbOutput.Text = "true";
            }
            else
            {
                lbOutput.Text = "conditions are not satisfied";
            }
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }
    }
}
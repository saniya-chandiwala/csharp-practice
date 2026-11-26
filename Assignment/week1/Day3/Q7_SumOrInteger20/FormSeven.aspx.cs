using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class FormSeven : System.Web.UI.Page
{
    int first, second;

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnResult_Click(object sender, EventArgs e)
    {
        try
        {
            first = Convert.ToInt32(txtFirst.Text);
            second = Convert.ToInt32(txtSecond.Text);

            if(first==20 || second==20|| (first + second) == 20)
            {
                lbResult.Text = "true";
            }
            else
            {
                lbResult.Text = "conditions are not satisfied";
            }
        }
        catch(Exception ex)
        {
            Response.Write(ex.Message);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class FormNine : System.Web.UI.Page
{
    int sum;

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnCalculate_Click(object sender, EventArgs e)
    {
        try
        {
            for(int i = 1; i<=10; i++)
            {
                sum += i;
            }

            lbSum.Text = sum.ToString();
        }
        catch(Exception ex)
        {
            Response.Write(ex.Message);
        }

    }
}
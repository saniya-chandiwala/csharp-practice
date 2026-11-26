using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Q1Form : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnCalculate_Click(object sender, EventArgs e)
    {
        try
        {
            lbSolution1.Text = (-1 + 4 * 6).ToString();
            lbSolution2.Text = ((35 + 5) % 7).ToString();
            lbSolution3.Text = (14 + -4 * 6 % 11).ToString();
            lbSolution4.Text = (2 + 15 / 6 * 1 - 7 % 2).ToString();

        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }
    }
}
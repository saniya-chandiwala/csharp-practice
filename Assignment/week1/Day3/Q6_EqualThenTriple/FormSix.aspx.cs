using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class FormSix : System.Web.UI.Page
{
    int first, second, sum;

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnCalculate_Click(object sender, EventArgs e)
    {
        try
        {
            first = Convert.ToInt32(txtFirst.Text);
            second = Convert.ToInt32(txtSecond.Text);

            if(first == second)
            {
                lbResult.Text = ((first + second) * 3).ToString();
                lbResultHeading.Text = "Triple of thier Sum";
            }
            else
            {
                lbResult.Text = (first + second).ToString();
                lbResultHeading.Text = "Summation";
            }
        }
        catch(Exception ex)
        {
            Response.Write(ex.Message);
        }
    }
}
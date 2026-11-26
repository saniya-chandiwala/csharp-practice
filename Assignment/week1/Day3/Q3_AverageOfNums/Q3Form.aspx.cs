using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Q3Form : System.Web.UI.Page
{
    double firstValue, secondValue, thirdValue, fourthValue;

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnCalculate_Click(object sender, EventArgs e)
    {
        try
        {
            firstValue = Convert.ToDouble(txtFirstValue.Text);
            secondValue = Convert.ToDouble(txtSecondValue.Text);
            thirdValue = Convert.ToDouble(txtThridValue.Text);
            fourthValue = Convert.ToDouble(txtFourthValue.Text);

            lbResult.Text = ((firstValue + secondValue + thirdValue + fourthValue) / 4).ToString();
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TaxCalcLib;

public partial class CalcForm : System.Web.UI.Page
{
    double amount;

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnCalc_Click(object sender, EventArgs e)
    {
        try
        {
            amount = Convert.ToDouble(txtAmount.Text);
            if (amount > 0)
            {
                lbGstAmount.Text = TaxCalc.TaxAmount(amount).ToString();
                lbTotalAmount.Text = TaxCalc.TotalAmount(amount).ToString();
            }
            else
            {
                lbGstAmount.Text = "invalid data entered";
                lbTotalAmount.Text = "invalid data entered";
            }
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }
    }
}
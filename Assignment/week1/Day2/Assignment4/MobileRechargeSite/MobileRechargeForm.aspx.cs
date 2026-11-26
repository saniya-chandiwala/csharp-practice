using MobileRechargeLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

#region
/// <summary>
///  class with button to calculate the final recharge amount and amount of gst applied
/// </summary>
#endregion
public partial class MobileRechargeForm : System.Web.UI.Page
{
    Recharge recharge;
    double amount;

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    // butoon to calculate results
    protected void lbCalculatePrice_Click(object sender, EventArgs e)
    {
        try
        {
            recharge = new Recharge();
            amount = Convert.ToDouble(txtPlanAmount.Text);

            if (amount > 0)
            {
                recharge.PlanAmount = amount; 

                lbGst.Text = recharge.CalculateGST().ToString();
                lbAmount.Text = recharge.CalculateFinalAmount().ToString();
            }
            else
            {
                lbGst.Text = "Invalid Data Entered";
                lbAmount.Text = "Data Cannot Be Calculated";
            }
        }
        catch(Exception exp)
        {
            Response.Write(exp.Message);
        }

    }
}
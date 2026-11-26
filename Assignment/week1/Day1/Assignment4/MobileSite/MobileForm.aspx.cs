using MobileLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

#region
/// <summary>
/// class to calculate mobile recharge
/// </summary>
#endregion
public partial class MobileForm : System.Web.UI.Page
{
    Recharge recharge = new Recharge();
    double planAmount;

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    // calculate gst
    protected void btnGST_Click(object sender, EventArgs e)
    {
        planAmount = Convert.ToDouble(txtPlanAmount.Text);
        double gst = recharge.CalculateGST(planAmount);
        lbGST.Text = gst.ToString();
    }

    // calculate total payable amount
    protected void btnTotalAmount_Click(object sender, EventArgs e)
    {
        planAmount = Convert.ToDouble(txtPlanAmount.Text);
        double amount = recharge.CalculateFinalAmount(planAmount);
        lbTotalAmount.Text = amount.ToString();
    }
}
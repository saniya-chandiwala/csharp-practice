using ElectricityDeptLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class BillForm : System.Web.UI.Page
{
    BillCalc bill;
    double units;

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnBill_Click(object sender, EventArgs e)
    {
        try
        {
            bill = new BillCalc();

            units = Convert.ToDouble(txtUnits.Text);

            if (units > 0)
            {
                bill.UnitsConsumed = units;

                lblBill.Text = "Consumer Number: " + txtNum.Text + 
                    "<br>Rate per unit: 0.8" + 
                    "<br>Consumed Units: " + units + 
                    "<br>Total: " + bill.CalculateBill().ToString();

                lblMsg.Text = " ";
            }
            else
            {
                lblMsg.Text = "Invaild units entered";
                lblBill.Text = " ";
            }
        }  
        catch(Exception ex)
        {
            Response.Write(ex.Message);
        }

    }
}
using CurrencyConverterLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ConverterForm : System.Web.UI.Page
{
    double amount; 

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnConvert_Click(object sender, EventArgs e)
    {
        try
        {
            amount = Convert.ToDouble(txtInr.Text);

            if (amount > 0)
            {
                lbUsdAmount.Text = CurrencyConv.InrToUsd(amount).ToString();
            }
            else
            {
                lbUsdAmount.Text = "invalid amount entered";
            }
        }
        catch(Exception ex)
        {
            Response.Write(ex.Message);
        }
    }
}
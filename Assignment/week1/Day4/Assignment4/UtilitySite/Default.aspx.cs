using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UtilityLib;

public partial class _Default : System.Web.UI.Page
{
    string cardType;
    double amount;

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnCalculate_Click(object sender, EventArgs e)
    {
        try
        {
            cardType = ddlCardType.SelectedValue;
            amount = Convert.ToDouble(txtAmount.Text);

            if (amount > 0)
            {
                lblDetails.Text =
                "Card Type: " + cardType +
                "<br>Cashback Rate: " + CreditCard.Rate(cardType) +
                "<br>Cashback: " + CreditCard.Cashback(cardType, amount) +
                "<br>Final Amount: " + CreditCard.FinalAmount(cardType, amount);
            }
            else
            {
                lblDetails.Text = "invaild amount entered";
            }
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }
    }
}
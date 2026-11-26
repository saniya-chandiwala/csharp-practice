using PetrolPumpLib;
using System;

#region
/// <summary>
/// bill generation class
/// </summary>
#endregion
public partial class BillForm : System.Web.UI.Page
{
    Petrol p;
    double litre;

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    // button to generate bill
    protected void btnCalculate_Click(object sender, EventArgs e)
    {
        try
        {
            p = new Petrol();
            litre = Convert.ToDouble(txtLitre.Text);

            if (litre > 0)
            {
                p.CustomerName = txtName.Text;
                p.LitresPurchased = litre;

                lblBill.Text = "Customer Name: " + p.CustomerName + "<br>" + "Cost Per Litre: 94.7 <br>" + "Litres Purchased: " + litre + "<br>" + "Total Price: " + p.BillGeneration().ToString();

                lblError.Text = " ";
            }
            else
            {
                lblError.Text = "invaild litres entered";
                lblBill.Text = " ";
            }
        }
        catch(Exception ex)
        {
            Response.Write(ex.Message);
        }
    }
}
using CarLib;
using System;


public partial class ServiceForm : System.Web.UI.Page
{
    Car c1;
    Car c2;
    Car c3;
    CarService serv;

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnCalculate_Click(object sender, EventArgs e)
    {
        serv = new CarService();

        

        switch (ddlOptions.SelectedValue)
        {
            case "Mercedes":
                lblOgCost.Text = "Original Cost: " + c1.ServiceCost;
                lblUpdCost.Text = "Updated Cost: " + serv.CalculateTotalServiceCost(c1);
                break;

            case "Honda":
                lblOgCost.Text = "Original Cost: " + c2.ServiceCost;
                lblUpdCost.Text = "Updated Cost: " + serv.CalculateTotalServiceCost(c2);
                break;

            case "Nissan":
                lblOgCost.Text = "Original Cost: " + c3.ServiceCost;
                lblUpdCost.Text = "Updated Cost: " + serv.CalculateTotalServiceCost(c3);
                break;

        }
    }
}
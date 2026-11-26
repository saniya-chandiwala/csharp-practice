using System;
using RentalSysLib;

public partial class Rental : System.Web.UI.Page
{
    IRentable rent;
    int days;
    double totalRent;

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnCalc_Click(object sender, EventArgs e)
    {
        try
        {
            days = Convert.ToInt32(txtDays.Text);

            if (days > 0)
            {
                if (rblVehicle.SelectedValue == "Car")
                {
                    rent = new Car() { VehicleNumber = 101, Model = "Mercedes", RentPerDay = 1000 };
                }
                else
                {
                    rent = new Bike() { VehicleNumber = 102, Model = "BMW", RentPerDay = 500 };
                }

                totalRent = rent.CalculateRent(days);

                lblOutput.Text = rent.DisplayVehicleDetails();
            }
            else
            {
                lblOutput.Text = "invaild data entered";
            }
            
        }
        catch(Exception ex)
        {
            Response.Write(ex.Message);
        }
    }
}
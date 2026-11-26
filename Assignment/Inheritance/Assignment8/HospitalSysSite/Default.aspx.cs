using HospitalSys;
using System;

public partial class _Default : System.Web.UI.Page
{
    HospitalStaff staff;

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnDisplay_Click(object sender, EventArgs e)
    {
        try
        {
            //staff = new Doctor(101, "doc");
            //lblDisplay.Text = staff.DisplayStaffDetails() +"<br/>" + staff.CalculateSalary().ToString();

            //staff = new Nurse(101, "nurse");
            //lblDisplay.Text = staff.DisplayStaffDetails() +"<br/>" + staff.CalculateSalary().ToString();

            staff = new SeniorDoctor(101, "senior doc");
            lblDisplay.Text = staff.DisplayStaffDetails() + "<br/>" + staff.CalculateSalary().ToString();

        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }
    }
}
using EmpPromLib;
using System;

public partial class PromoForm : System.Web.UI.Page
{
    Employee emp;
    EmpDetails details;

    protected void Page_Load(object sender, EventArgs e)
    {
        details = new EmpDetails();
    }


    protected void ddlEmps_SelectedIndexChanged(object sender, EventArgs e)
    {
        emp = details.GetEmployee(Convert.ToInt32(ddlEmps.SelectedValue));
        lblDetails.Text = "Employee Id: " + emp.Id +
                "<br>Employee Name: " + emp.Name +
                "<br>Employee Dept: " + emp.Dept +
                "<br>Employee Salary: " + emp.Salary;
    }

    protected void BtnPromote_Click(object sender, EventArgs e)
    {
        try
        {
            emp = details.GetEmployee(Convert.ToInt32(ddlEmps.SelectedValue));
            emp = details.GetPromotedEmployee(emp);

            lblNewDetails.Text = "Employee Id: " + emp.Id +
                "<br>Employee Name: " + emp.Name +
                "<br>Employee Dept: " + emp.Dept +
                "<br>Employee Salary: " + emp.Salary;
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }
    }
}
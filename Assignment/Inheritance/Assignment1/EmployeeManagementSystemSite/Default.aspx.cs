using EmployeeManagementSystemLib;
using System;


public partial class _Default : System.Web.UI.Page
{
    Developer d;
    Manager m;

    protected void Page_Load(object sender, EventArgs e)
    {

    }


    protected void btnCalculate_Click(object sender, EventArgs e)
    {
        d = new Developer() { EmpId = 101, EmpName = "ABC", Salary = 123456 };
        m = new Manager() { EmpId = 102, EmpName = "XYZ", Salary = 12345678 };

        if(ddlEmp.SelectedValue == "Manager")
        {
            lblDetails.Text = "Manager Details" + "<br/>Id: " + m.EmpId + "<br/>Name" + m.EmpName + "<br/>Salary: " + m.Salary + "<br/>Bonus: " + m.CalculateBonus();
        }
        else
        {
            lblDetails.Text = "Developer Details" + "<br/>Id: " + d.EmpId + "<br/>Name" + d.EmpName + "<br/>Salary: " + d.Salary + "<br/>Bonus: " + d.CalculateBonus();
        }
    }
}
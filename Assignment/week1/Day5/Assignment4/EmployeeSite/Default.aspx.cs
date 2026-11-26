using EmployeeLib;
using System;

public partial class _Default : System.Web.UI.Page
{
    Emp emp;
    int id; 

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnCreate_Click(object sender, EventArgs e)
    {
        try
        {
            id = Convert.ToInt32(txtId.Text);
            emp = new Emp(id, txtName.Text, txtDept.Text);

            lblDetails.Text = "Employee Id: " + id + "<br> Employee Name: " + emp.EmpName + "<br> Employee Dept: " + emp.EmpDept;
        }
        catch(Exception ex)
        {
            Response.Write(ex.Message);
        }
    }
}
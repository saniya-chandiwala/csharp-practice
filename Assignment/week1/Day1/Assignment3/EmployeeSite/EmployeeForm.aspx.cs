using EmployeeLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

#region
/// <summary>
/// calculator to calculate employee salary.
/// </summary>
#endregion
public partial class EmployeeForm : System.Web.UI.Page
{
    double hra, da, salary, basicSalary;
    Employee emp = new Employee();

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    // calculate HRA
    protected void btnHRA_Click(object sender, EventArgs e)
    {
        try
        {
            basicSalary = Convert.ToDouble(txtBasicSalary.Text);
            hra = emp.CalculateHRA(basicSalary);
            lbHRA.Text = hra.ToString();
        }
        catch (Exception ex)
        {
            Response.Write(ex);
        }

    }

    // calculate DA
    protected void btnDA_Click(object sender, EventArgs e)
    {
        try
        {
            basicSalary = Convert.ToDouble(txtBasicSalary.Text);
            da = emp.CalculateDA(basicSalary);
            lbDA.Text = da.ToString();
        }
        catch (Exception ex)
        {
            Response.Write(ex);
        }
    }

    // calculate gross salary
    protected void btnGrossSalary_Click(object sender, EventArgs e)
    {
        try
        {
            basicSalary = Convert.ToDouble(txtBasicSalary.Text);
            salary = emp.CalculateGrossSalary(basicSalary);
            lbGrossSalary.Text = salary.ToString();
        }
        catch (Exception ex)
        {
            Response.Write(ex);
        }
    }
}
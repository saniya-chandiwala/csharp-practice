using EmpSalaryLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

#region
/// <summary>
/// class to calculate employee salary
/// </summary>
#endregion

public partial class EmpSalaryForm : System.Web.UI.Page
{
    Employee emp;
    double salary;

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    // on click HRA, DA and Gross Salary will be calculated
    protected void btnCalculateSalary_Click(object sender, EventArgs e)
    {
        try
        {
            emp = new Employee();
            salary = Convert.ToDouble(txtBasicSalary.Text);

            if(emp.BasicSalary >= 0)
            {
                emp.BasicSalary = salary;
                lbHraAmount.Text = emp.CalculateHRA().ToString();
                lbDaAmount.Text = emp.CalculateDA().ToString();
                lbGrossSalaryAmount.Text = emp.CalculateGrossSalary().ToString();
            }
            else
            {
                lbHraAmount.Text = "Invalid Data Entered";
                lbDaAmount.Text = "Invalid Data Entered";
                lbGrossSalaryAmount.Text = "Invalid Data Entered";
            }

        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }
    }
}
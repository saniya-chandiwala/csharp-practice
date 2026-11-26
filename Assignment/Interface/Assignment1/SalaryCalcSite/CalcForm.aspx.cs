using System;
using SalaryCalcLib;

public partial class CalcForm : System.Web.UI.Page
{
    ISalary salary;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSalary_Click(object sender, EventArgs e)
    {
        try
        {
            if(ddlEmp.SelectedValue == "Permanent")
            {
                salary = new PermanentEmployee() { Name = "Saniya", Salary = 16000 };
            }
            else
            {
                salary = new ContractEmployee() { Name = "Ayesha", NoOfHours = 11, PerHourPay = 600 };
            }

            lblSalary.Text = "Salary: " + salary.CalculateSalary();
        }
        catch(Exception ex)
        {
            Response.Write(ex.Message);
        }
    }
}
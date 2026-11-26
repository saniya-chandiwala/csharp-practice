using EmpPayrollLib;
using System;

public partial class _Default : System.Web.UI.Page
{
    Employee emp;
    Payroll p;
    PayrollHandler del;
    
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnCalculate_Click(object sender, EventArgs e)
    {
        try
        {
            emp = new Employee();
            emp.EmployeeId = Convert.ToInt32(txtId.Text);
            emp.EmployeeName = txtName.Text;
            emp.BasicSalary = Convert.ToDouble(txtSalary.Text);

            del = emp.CalculateHRA;
            del += emp.CalculateDA;
            del += emp.CalculateTax;

            p = new Payroll();
            p.PerformPayroll(del);

            lblOutput.Text = emp.BasicSalary.ToString();
        }
        catch (Exception ex) {
            Response.Write(ex.Message);
        }

    }
}
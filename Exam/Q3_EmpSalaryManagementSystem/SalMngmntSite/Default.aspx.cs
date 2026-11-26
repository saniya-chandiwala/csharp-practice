using SalMngmntLib;
using System;

public partial class _Default : System.Web.UI.Page
{
    Employee emp;
    SalCalculator calculator;

    int id;
    string name, dept;
    double sal;

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnCalculate_Click(object sender, EventArgs e)
    {
        try
        {
            id = Convert.ToInt32(txtId.Text);
            name = txtName.Text;
            dept = txtDepartment.Text;
            sal = Convert.ToDouble(txtSalary.Text);

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(dept) || sal <= 0)
            {
                lblError.Text = "Invalid data entered";
                return;
            }
            else
            {
                calculator = new SalCalculator();

                emp = new Employee() { EmpId = id, EmpName = name, Department = dept, BasicSalary = sal };

                double housing;
                double transportation;
                double special;

                calculator.CalculateAllowance(emp, out housing, out transportation, out special);

                double total = calculator.CalculateTotal(emp);
                double tax = calculator.CalculateTax(emp);
                double netSalary = calculator.CalculateNetSalary(emp);

                lblHousingOutput.Text = housing.ToString();
                lblTransportationOutput.Text = transportation.ToString();
                lblSpecialOutput.Text = special.ToString();
                lblTotalOutput.Text = total.ToString();
                lblTaxOutput.Text = tax.ToString();
                lblNetSalaryOutput.Text = netSalary.ToString();
            }
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }
    }
}
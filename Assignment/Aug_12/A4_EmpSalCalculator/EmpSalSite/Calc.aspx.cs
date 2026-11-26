using System;

public partial class Calc : System.Web.UI.Page
{
    double sal, allowance, bonus, deduction, result;

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnCalculate_Click(object sender, EventArgs e)
    {
        try
        {
            sal = Convert.ToDouble(txtSal.Text);
            allowance = Convert.ToDouble(txtAllowance.Text);
            bonus = Convert.ToDouble(txtBonus.Text);
            deduction = Convert.ToDouble(txtDeduction.Text);

            switch (ddlOptions.SelectedValue)
            {
                case "1":
                    result = EmpSalLib.SalaryCalculator.CalculateSalary(sal);
                    break;

                case "2":
                    result = EmpSalLib.SalaryCalculator.CalculateSalary(sal,allowance);
                    break;

                case "3":
                    result = EmpSalLib.SalaryCalculator.CalculateSalary(sal, allowance,bonus);
                    break;

                case "4":    
                    result = EmpSalLib.SalaryCalculator.CalculateSalary(sal, allowance,bonus,deduction);
                    break;
            }

            lblResult.Text = result.ToString();
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }
    }
}
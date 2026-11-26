using SalaryComparisonLib;
using System;

public partial class _Default : System.Web.UI.Page
{
    Employee emp1;
    Employee emp2;
    Employee result;
    Salary sal;

    protected void Page_Load(object sender, EventArgs e)
    {

    }


    protected void btnCompare_Click(object sender, EventArgs e)
    {
        try
        {
            emp1 = new Employee() { EmpId = 101, EmpName = "abc", Salary = 1000 };
            emp2 = new Employee() { EmpId = 102, EmpName = "xyz", Salary = 2000 };

            sal = new Salary();
            result = sal.CompareSalary(emp1, emp2);

            Response.Write("Employe with Higher Salary" + "<br>Employee Id : " + result.EmpId + "<br>Employee Name : " + result.EmpName + "<br>Employee Salary : " + result.Salary);

        }

        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }
    }
}
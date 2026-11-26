using MultiSortLib;
using System;
using System.Collections.Generic;

public partial class _Default : System.Web.UI.Page
{
    static List<Employee> emps = new List<Employee>();

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOg_Click(object sender, EventArgs e)
    {
        emps.Clear();

        emps.Add(new Employee() { EmployeeId = 101, EmployeeName = "Saniya", Salary = 20000, Department = "Training" });
        emps.Add(new Employee() { EmployeeId = 102, EmployeeName = "Ayesha", Salary = 25000, Department = "HR" });
        emps.Add(new Employee() { EmployeeId = 103, EmployeeName = "Priya", Salary = 23000, Department = "Training" });
        emps.Add(new Employee() { EmployeeId = 104, EmployeeName = "Niyati", Salary = 18000, Department = "IT" });
        emps.Add(new Employee() { EmployeeId = 105, EmployeeName = "Vanshika", Salary = 16000, Department = "Development" });

        lblOg.Text = "";
        foreach(Employee emp in emps)
        {
            lblOg.Text += "Employee Id: " + emp.EmployeeId + " Employee Name: " + emp.EmployeeName + " Employee Salary: " + emp.Salary + " Employee Department: " + emp.Department + "<br/>";
        }
    }

    protected void btnName_Click(object sender, EventArgs e)
    {
        emps.Sort(new SortName());

        lblName.Text = "";
        foreach (Employee emp in emps)
        {
            lblName.Text += "Employee Id: " + emp.EmployeeId + " Employee Name: " + emp.EmployeeName + " Employee Salary: " + emp.Salary + " Employee Department: " + emp.Department + "<br/>";
        }
    }

    protected void btnSal_Click(object sender, EventArgs e)
    {
        emps.Sort(new SortSalary());

        lblSalary.Text = "";
        foreach (Employee emp in emps)
        {
            lblSalary.Text += "Employee Id: " + emp.EmployeeId + " Employee Name: " + emp.EmployeeName + " Employee Salary: " + emp.Salary + " Employee Department: " + emp.Department + "<br/>";
        }
    }

    protected void btnDept_Click(object sender, EventArgs e)
    {
        emps.Sort(new SortDept());

        lblDept.Text = "";
        foreach (Employee emp in emps)
        {
            lblDept.Text += "Employee Id: " + emp.EmployeeId + " Employee Name: " + emp.EmployeeName + " Employee Salary: " + emp.Salary + " Employee Department: " + emp.Department + "<br/>";
        }
    }
}
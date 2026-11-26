using SortSalLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SortedEmps : System.Web.UI.Page
{
    static List<Employee> emps = new List<Employee>();

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnEmps_Click(object sender, EventArgs e)
    {
        emps.Clear();

        emps.Add(new Employee() { EmployeeId = 1, EmployeeName = "Niyati", Salary = 20000 });
        emps.Add(new Employee() { EmployeeId = 2, EmployeeName = "Muskan", Salary = 50000 });
        emps.Add(new Employee() { EmployeeId = 3, EmployeeName = "Priya", Salary = 30000 });
        emps.Add(new Employee() { EmployeeId = 4, EmployeeName = "Ayesha", Salary = 40000 });
        emps.Add(new Employee() { EmployeeId = 5, EmployeeName = "Saniya", Salary = 60000 });

        lblBefore.Text = "";

        foreach(Employee emp in emps)
        {
            lblBefore.Text += "Employee Id: " + emp.EmployeeId + " Employee Name: " + emp.EmployeeName + " Salary: " + emp.Salary + "<br/>";
        }
    }

    protected void btnSort_Click(object sender, EventArgs e)
    {
        emps.Sort();

        foreach (Employee emp in emps)
        {
            lblAfter.Text += "Employee Id: " + emp.EmployeeId + " Employee Name: " + emp.EmployeeName + " Salary: " + emp.Salary + "<br/>";
        }
    }
}
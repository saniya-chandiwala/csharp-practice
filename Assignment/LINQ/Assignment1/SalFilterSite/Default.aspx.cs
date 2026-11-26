using SalFilterLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

//1. Employee Salary Filter

//Scenario:
//A company has a list of employees with Id, Name, Department, and Salary.

//Question:
//Using LINQ, retrieve all employees whose salary is greater than ₹50,000.

//Follow-up:

//How would you retrieve only their names?
//How would you sort them by salary in descending order?


public partial class _Default : System.Web.UI.Page
{
    EmployeeDetails details;
    List<Employee> emps;

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnPerform_Click(object sender, EventArgs e)
    {
        details = new EmployeeDetails();
        emps = details.GetEmpList();

        var salGreater = emps.Where(x => x.Salary > 50000);
        foreach (Employee emp in salGreater)
        {
            lblSalGreater.Text += "Id: " + emp.Id + " Name: " + emp.Name + " Salary: " + emp.Salary + " Department: " + emp.Department + "<br/>";
        }

        //var names = salGreater.Select(x => x.Name);
        var names = emps.Where(x => x.Salary > 50000).Select(x => x.Name);
        foreach (var emp in names)
        {
            lblNames.Text += emp + "<br/>";
        }

        //var desc = salGreater.OrderByDescending(x => x.Salary);
        var desc = emps.Where(x => x.Salary > 50000).OrderByDescending(x => x.Salary);
        foreach (Employee emp in desc)
        {
            lblSalDesc.Text += "Id: " + emp.Id + " Name: " + emp.Name + " Salary: " + emp.Salary + " Department: " + emp.Department + "<br/>";
        }


        foreach (Employee emp in emps)
        {
            lblOg.Text += "Id: " + emp.Id + " Name: " + emp.Name + " Salary: " + emp.Salary + " Department: " + emp.Department + "<br/>";
        }
    }
}
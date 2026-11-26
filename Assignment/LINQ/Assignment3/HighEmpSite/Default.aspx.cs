using HighEmpLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

//Question:
//Using LINQ, find the employee with the maximum salary.

//Follow-up:

//What is the difference between Max() and OrderByDescending().First()?
//What happens if the employee collection is empty?

public partial class _Default : System.Web.UI.Page
{
    EmpDetails details;
    List<Employee> emps;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnDisplay_Click(object sender, EventArgs e)
    {
        details = new EmpDetails();
        emps = details.GetEmpList();

        // returns value
        //double empSal = emps.Max(x=>x.Salary);
        
        // we get employee obj using first
        //Employee emp = emps.First(x => x.Salary == empSal);

        // if collection is empty invalidoperationException
        Employee highEmp = emps.OrderByDescending(x => x.Salary).FirstOrDefault();

        if(highEmp != null)
        {
            lblSalMax.Text = "Name: " + highEmp.Name + " Salary: " + highEmp.Salary;
        }
        else
        {
            lblSalMax.Text = "No emps found";
        }
        

        foreach(Employee emp in emps)
        {
            lblOg.Text += "Name: " + emp.Name + " Salary: " + emp.Salary + "<br/>";
        }
    }
}
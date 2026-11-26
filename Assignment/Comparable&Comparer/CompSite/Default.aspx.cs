using CompLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {

    }



    protected void btnName_Click(object sender, EventArgs e)
    {
        List<Employee> emps = new List<Employee>{
            new Employee() { EmpId = 101, EmpName = "saniya", EmpSalary = 16000 },
            new Employee() { EmpId = 103, EmpName = "ayesha", EmpSalary = 20000 },
            new Employee() { EmpId = 102, EmpName = "saniya", EmpSalary = 16000 }
        };

        emps.Sort(new NameSal());

        foreach (Employee emp in emps)
        {
            lblName.Text += emp.EmpId + " " + emp.EmpName + " " + emp.EmpSalary + "<br/>";
        }
    }

    protected void btnId_Click(object sender, EventArgs e)
    {
        List<Employee> emps = new List<Employee>{
            new Employee() { EmpId = 101, EmpName = "saniya", EmpSalary = 16000 },
            new Employee() { EmpId = 103, EmpName = "ayesha", EmpSalary = 20000 },
            new Employee() { EmpId = 102, EmpName = "saniya", EmpSalary = 24000 }
        };

        emps.Sort();

        foreach (Employee emp in emps)
        {
            lblId.Text += emp.EmpId + " " + emp.EmpName + " " + emp.EmpSalary + "<br/>";
        }
    }
}
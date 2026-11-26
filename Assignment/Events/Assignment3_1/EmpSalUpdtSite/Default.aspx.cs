using EmpSalUpdtLib;
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

    protected void btnSal_Click(object sender, EventArgs e)
    {
        Employee emp = new Employee() { EmpId = 101, EmpName = "abc", EmpSalary = 16000 };

        Subscriber hr = new Subscriber() { Department = "HR Dept" };
        Subscriber finance = new Subscriber() { Department = "Finance Dept" };

        hr.Subscribe(emp);
        finance.Subscribe(emp);

        double sal = Convert.ToDouble(txtSal.Text);
        emp.ChangeSalary(sal);
    }
}

public class Subscriber
{
    public string Department { get; set; }
    public void Subscribe(Employee emp)
    {
        emp.SalChangeEvent += DisplaySalChangeNotif;
    }

    public void DisplaySalChangeNotif()
    {
        HttpContext.Current.Response.Write(Department + ": Employee Salary Changed <br/>");
    }
}
using EmployeeCounterLib;
using System;


public partial class EmpCountForm : System.Web.UI.Page
{
    EmpCounter emp;

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        emp = new EmpCounter();
        lbCount.Text = emp.GenerateCount().ToString();
    }
}
using System;
using EmpDeptLib;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    Details details;
    List<Employee> employees;
    List<Department> departments;

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnDisplay_Click(object sender, EventArgs e)
    {
        details = new Details();

        employees = details.GetEmployeeList();
        departments = details.GetDepartmentList();

        var output = employees.Join(departments, emp => emp.DeptId, dept => dept.DeptId, (emp, dept) => new { Name = emp.EmpName, Dept = dept.DeptName });

        foreach (var item in output)
        {
            lblOutput.Text += "Employee: " + item.Name + " Department: " + item.Dept + "<br/>";
        }
    }
}
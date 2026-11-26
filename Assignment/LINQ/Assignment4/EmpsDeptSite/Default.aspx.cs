using System;
using EmpsDeptLib;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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

        var deptGrps = emps.GroupBy(x => x.Department);

        foreach(var grp in deptGrps)
        {
            lblOp.Text += grp.Key + " = " + grp.Count() + "<br/>";
        }
    }
}
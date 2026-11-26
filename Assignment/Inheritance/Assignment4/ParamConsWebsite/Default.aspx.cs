using ParamConsInBaseClass;
using System;

public partial class _Default : System.Web.UI.Page
{
    Developer dev;

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnDetails_Click(object sender, EventArgs e)
    {
        dev = new Developer(101, "saniya", "training", "c#", 1);

        lblDetails.Text = "Id: " + dev.EmpId + "<br/>Name: " + dev.EmpName + "<br/>Dept: " + dev.EmpDept + "<br/>Programming Language: " + dev.ProgrammingLanguage + "<br/>Experience: " + dev.Experience;
    }
}
using EmpRolesLib;
using System;

public partial class _Default : System.Web.UI.Page
{
    Manager a;

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnDisplay_Click(object sender, EventArgs e)
    {
        a = new Manager();

        Response.Write(a.DisplayRole());
    }
}
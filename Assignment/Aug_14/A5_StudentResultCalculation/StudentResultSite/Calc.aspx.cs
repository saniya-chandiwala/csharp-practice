using StudentResultLib;
using System;

public partial class Calc : System.Web.UI.Page
{
    Student s;
    Calculation c;

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnResult_Click(object sender, EventArgs e)
    {
        s = new Student() { Name = "saniya", English = 80, Maths = 40, Science = 60 };
        c = new Calculation();

        lblDetails.Text = c.Display(s);

        c.CalculateResult(s);

        lblResult.Text = c.Display(s);

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class FormTwelve : System.Web.UI.Page
{
    int num, cube;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnCalculate_Click(object sender, EventArgs e)
    {
        num = Convert.ToInt32(txtNum.Text);

        if(num > 0)
        {
            for (int i = 1; i<=num; i++)
            {
                cube = i * i * i;
            }
            lblCube.Text = cube.ToString();
        }
        else
        {
            lblCube.Text = "number should be greater than 0";
        }
    }
}
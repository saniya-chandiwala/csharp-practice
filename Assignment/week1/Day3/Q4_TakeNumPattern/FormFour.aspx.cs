using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class FormFour : System.Web.UI.Page
{
    int num;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnPattern_Click(object sender, EventArgs e)
    {
        try
        {
            num = Convert.ToInt32(txtNumber.Text);
            for(int i = 1; i<=5; i++)
            {
                for(int j = 1; j <= 3; j++)
                {
                    if(i == 1 || i == 5 || j == 3 || j == 1)
                    {
                        Response.Write(num);
                    }
                    else
                    {
                        Response.Write("&nbsp&nbsp");
                    }
                }
                Response.Write("<br>");
            }
        }
        catch(Exception ex)
        {
            Response.Write(ex.Message );
        }
    }
}
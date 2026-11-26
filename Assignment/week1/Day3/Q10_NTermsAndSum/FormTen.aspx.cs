using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class FormTen : System.Web.UI.Page
{
    int n, sum;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSum_Click(object sender, EventArgs e)
    {
        n = Convert.ToInt32(txtNumber.Text);

        if(n > 0) {
            for (int i = 0; i <= n; i++)
            {
                Response.Write(i + "<br>");
                sum += i;
            }
            lbSum.Text = sum.ToString();
        }
        
    }
}
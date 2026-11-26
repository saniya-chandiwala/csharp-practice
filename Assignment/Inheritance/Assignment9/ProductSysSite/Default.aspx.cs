using ProductSysLib;
using System;

public partial class _Default : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnDisplay_Click(object sender, EventArgs e)
    { 
        Electronics el = new Electronics(101, "Laptop", 50000);
        Clothing c = new Clothing(102, "Jacket", 3000);

        Product p = new Clothing(102, "Jacket", 3000);

        lblDisplay.Text = el.DisplayProduct();
        //lblDisplay.Text = c.DisplayProduct();

        //lblDisplay.Text = p.DisplayProduct();
    }
}
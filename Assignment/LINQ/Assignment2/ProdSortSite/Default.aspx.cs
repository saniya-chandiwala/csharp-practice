using ProdSortLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    ProdDetails details;
    List<Product> products;

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnDisplay_Click(object sender, EventArgs e)
    {
        details = new ProdDetails();
        products = details.GetListData();

        var category = products.Where(x => x.Category == "Electronics");
        foreach (Product p in category)
        {
            lblElectronics.Text += "Id: " + p.Id + " Name: " + p.Name + " Category: " + p.Category + " Price: " + p.Price + "<br/>";
        }

        var priceGreater = category.Where(x => x.Price >= 10000 && x.Price <= 50000);
        foreach (Product p in priceGreater)
        {
            lblPriceGreater.Text += "Id: " + p.Id + " Name: " + p.Name + " Category: " + p.Category + " Price: " + p.Price + "<br/>";
        }

        var sortPrice = priceGreater.OrderBy(x => x.Price);
        foreach (var p in sortPrice)
        {
            lblPriceSort.Text += "Name: " + p.Name + " Category: " + p.Category + " Price: " + p.Price + "<br/>";
        }

        foreach (Product p in products)
        {
            lblOg.Text += "Id: " + p.Id + " Name: " + p.Name + " Category: " + p.Category + " Price: " + p.Price + "<br/>";
        }
    }
}
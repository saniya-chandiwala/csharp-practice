using System;
using ProdsByCatLib;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

//Question:
//Using LINQ, group products by Category.

//Expected output:

//Electronics
//   Mobile
//   Laptop
//   Tablet

//Clothing
//   Shirt
//   Jeans
//   Jacket

//Follow-up:
//Display the number of products available in each category.

public partial class _Default : System.Web.UI.Page
{
    ProductDetails details;
    List<Product> products;

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnDisplay_Click(object sender, EventArgs e)
    {
        details = new ProductDetails();
        products = details.GetList();

        var categoryGrp = products.GroupBy(x => x.Category);

        foreach(var category in categoryGrp)
        {
            lblCategory.Text += "<br/>" + category.Key + "<br/>";

            foreach(var item in category)
            {
                lblCategory.Text += item.Name + "<br/>";
            }
        }

        foreach (var category in categoryGrp)
        {
            lblNumber.Text += category.Key + " : " + category.Count() + "<br/>";
        }

        foreach(Product p in products)
        {
            lblOg.Text += "Product Name: " + p.Name + " Product Category: " + p.Category + "<br/>";
        }
    }
}
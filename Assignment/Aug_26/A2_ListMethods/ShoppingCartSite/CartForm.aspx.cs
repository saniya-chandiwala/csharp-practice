using ShoppingCartLib;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class CartForm : System.Web.UI.Page
{
    int id;

    Product p;
    ProductDetails details = new ProductDetails();

    List<Product> products = new ProductDetails().GetProductsList();

    protected void Page_Load(object sender, EventArgs e)
    {
        
        
    }

    protected void btnDispAll_Click(object sender, EventArgs e)
    {        
        lblDisplay.Text = "";
        foreach(Product p in products)
        {
            lblDisplay.Text += "Product Id: " + p.ProductId + " Product Name: " + p.ProductName + " Price: " + p.Price + "<br/>";
        }
        lblDisplay.Text += "<br/>" + "Number Of Products: " + products.Count;
    }

    protected void btnMore_Click(object sender, EventArgs e)
    {
        products.AddRange(details.MoreProductsAdded());

        lblMore.Text = "";
        foreach (Product p in products)
        {
            lblMore.Text += "Product Id: " + p.ProductId + " Product Name: " + p.ProductName + " Price: " + p.Price + "<br/>";
        }
        lblMore.Text += "<br/>" + "Number Of Products: " + products.Count;
    }

    protected void btnContains_Click(object sender, EventArgs e)
    {
        id = Convert.ToInt32(txtId.Text);

        p = products.Find(x => x.ProductId == id);
        if(products.Contains(p))
        {
            lblOutput.Text = "Product Exists";
        }
        else
        {
            lblOutput.Text = "Product Does Not Exist";
        }
    }

    protected void btnFindProd_Click(object sender, EventArgs e)
    {
        id = Convert.ToInt32(txtId.Text);

        p = products.Find(x => x.ProductId == id);
        if (p!=null)
        {
            lblOutput.Text = "Product Id: " + p.ProductId + " Product Name: " + p.ProductName + " Price: " + p.Price + "<br/>";
        }
        else
        {
            lblOutput.Text = "Product Not Found";
        }
    }

    protected void btnCost_Click(object sender, EventArgs e)
    {
        List<Product> costlyProds = products.FindAll(x => x.Price >= 1000);

        lblCostProds.Text = "";
        foreach (Product p in costlyProds)
        {
            lblCostProds.Text += "Product Id: " + p.ProductId + " Product Name: " + p.ProductName + " Price: " + p.Price + "<br/>";
        }
    }

    protected void btnRemove_Click(object sender, EventArgs e)
    {
        id = Convert.ToInt32(txtId.Text);

        p = products.Find(x => x.ProductId == id);
        if (p != null)
        {
            products.Remove(p);
            lblOutput.Text = "Product Removed Successfully";
        }
        else
        {
            lblOutput.Text = "Product Not Found";
        }
    }

    protected void btnIndexRemove_Click(object sender, EventArgs e)
    {
        id = Convert.ToInt32(ddlIndex.SelectedValue);

        if (id >= 0 && id < products.Count)
        {
            products.RemoveAt(id);
            lblIndexed.Text = "Product Removed Successfully";
        }
        else
        {
            lblIndexed.Text = "Product Does Not Exist";
        }        
    }

    protected void btnInsertIdx_Click(object sender, EventArgs e)
    {
        id = Convert.ToInt32(ddlIndex.SelectedValue);
        p = new Product() { ProductId = 7, ProductName = "Brownie", Price = 1500 };

        if (id >= 0 && id < products.Count)
        {
            products.Insert(id, p);
            lblIndexed.Text = "Product Inserted Successfully<br/>" + "Product Id: " + p.ProductId + " Product Name: " + p.ProductName + " Price: " + p.Price + "<br/>"; ;
        }
        else
        {
            lblIndexed.Text = "Product Does Not Exist";
        }
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        lblClear.Text += "Number of Products Before: " + products.Count + "<br/>";

        products.Clear();

        lblClear.Text += "Number of Products After: " + products.Count + "<br/>";
    }
}
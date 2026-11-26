using OnlineShoppingLib;
using System;
using System.Collections.Generic;
using System.Linq;

public partial class QueryOutput : System.Web.UI.Page
{
    List<Product> products;
    List<ProductTag> productTags;
    List<Order> orders;
    List<Customer> customers;

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnQ1_Click(object sender, EventArgs e)
    {
        products = SampleData.GetProducts();

        var result = products.Where(x => x.Price > 1000).OrderBy(x => x.Category).ThenBy(x => x.ProductName);

        foreach (var item in result)
        {
            lblQ1Op.Text += item.ProductName + "  " + item.Category + " " + item.Price + "<br/>";
        }
    }

    protected void btnQ2_Click(object sender, EventArgs e)
    {
        products = SampleData.GetProducts();

        var result = products.OrderByDescending(x => x.Price).ThenByDescending(x => x.ProductName);

        foreach (var item in result)
        {
            lblQ2Op.Text += item.ProductName + " " + item.Price + "<br/>";
        }
    }

    protected void btnQ3_Click(object sender, EventArgs e)
    {
        products = SampleData.GetProducts();

        var result = products.GroupBy(x => x.Category);

        foreach (var item in result)
        {
            lblQ3Op.Text += item.Key + " : " + item.Count() + "<br/>";
        }
    }

    protected void btnQ4_Click(object sender, EventArgs e)
    {
        products = SampleData.GetProducts();

        var result = products.Select(x => new { x.ProductName, x.Price });

        foreach (var item in result)
        {
            lblQ4Op.Text += item.ProductName + " : " + item.Price + "<br/>";
        }
    }

    protected void btnQ5_Click(object sender, EventArgs e)
    {
        products = SampleData.GetProducts();
        productTags = SampleData.GetProductTags();

        #region 
        // joining productTags list with products list
        // based on id
        //  Product = p all data of p in product
        // lists in t.tags stored in Tags
        // tags is list hence selectmany on productTags
        // create new obj with product info - name & price + tag
        #endregion
        var result = productTags.Join(products, t => t.ProductId, p => p.ProductId, (t, p) => new { Product = p, Tags = t.Tags })
            .SelectMany(x => x.Tags, (x, tag) => new
            {
                x.Product.ProductName,
                x.Product.Price,
                Tag = tag
            });

        foreach (var item in result)
        {
            lblQ5Op.Text += item.ProductName + " " + item.Price + "  " + item.Tag + "<br/>";
        }
    }

    protected void btnQ6_Click(object sender, EventArgs e)
    {
        customers = SampleData.GetCustomers();
        orders = SampleData.GetOrders();
        products = SampleData.GetProducts();

        var result = from c in customers
                     join o in orders
                     on c.CustomerId equals o.CustomerId
                     join p in products
                     on o.ProductId equals p.ProductId
                     select new
                     {
                         c.CustomerName,
                         o.OrderId,
                         p.ProductName,
                         o.Amount
                     };

        foreach (var item in result)
        {
            lblQ6Op.Text += item.CustomerName + "  " + item.OrderId + "  " + item.ProductName + " " + item.Amount + "<br/>";
        }
    }

    protected void btnQ7_Click(object sender, EventArgs e)
    {
        orders = SampleData.GetOrders();

        double average = orders.Average(x => x.Amount);
        double minimum = orders.Min(x => x.Amount);
        double maximum = orders.Max(x => x.Amount);
        double total = orders.Sum(x => x.Amount);

        lblQ7Op.Text = "Average Sales: " + average + "<br/>Minimum Sales: " + minimum + "<br/>Maximum Sales: " + maximum + "<br/>Total Sales: " + total;
    }

    protected void btnQ8_Click(object sender, EventArgs e)
    {
        products = SampleData.GetProducts();
        string name = txtName.Text;

        bool priceGreater = products.All(x => x.Price > 0);

        bool outOfStock = products.Any(x => x.Stock == 0);

        bool productExists = products.Select(x => x.ProductName).Contains(name);

        lblQ8Op.Text =
            "All products have valid price: " + priceGreater +
            "<br/>At least one product is out of stock: " + outOfStock +
            "<br/>Entered Product exists: " + productExists;
    }

    protected void btnQ9_Click(object sender, EventArgs e)
    {
        products = SampleData.GetProducts();

        int position = Convert.ToInt32(txtPosition.Text);

        Product product = products.ElementAtOrDefault(position);

        if (product != null)
        {
            lblQ9Op.Text = position + " " + product.ProductName + " " + product.Price + "<br/>";
        }
        else
        {
            lblQ9Op.Text = "No product exists";
        }
    }

    protected void btnQ10_Click(object sender, EventArgs e)
    {
        products = SampleData.GetProducts();

        lblQ10Op.Text = "";

        Product firstProduct = products.FirstOrDefault(x => x.Price > 50000);

        if (firstProduct != null)
        {
            lblQ10Op.Text += "First Product: " + firstProduct.ProductName + "<br/>";
        }
        else
        {
            lblQ10Op.Text += "No matching first product found<br/>";
        }


        Product lastProduct = products.LastOrDefault(x => x.Price > 50000);

        if (lastProduct != null)
        {
            lblQ10Op.Text += "Last Product: " + lastProduct.ProductName + "<br/>";
        }
        else
        {
            lblQ10Op.Text += "No matching last product found<br/>";
        }


        try
        {
            Product uniqueProduct = products.SingleOrDefault(x => x.ProductId == 1);

            if (uniqueProduct != null)
            {
                lblQ10Op.Text += "Unique Product: " + uniqueProduct.ProductName;
            }
            else
            {
                lblQ10Op.Text += "No unique product found";
            }
        }
        catch (InvalidOperationException)
        {
            lblQ10Op.Text += "Multiple products matched the unique condition";
        }
    }
}
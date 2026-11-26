using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

//6. ArrayList – Dynamic Order Management
//Scenario
//A restaurant application receives orders.The application is an old system and uses ArrayList.

//Create an ArrayList containing different types of order-related information such as:

//Order ID
//Customer Name
//Quantity
//Total Amount
//Perform:

//Add values to the ArrayList.
//Display all values.
//Insert a value at a particular position.
//Remove a value.
//Remove a value at a particular index.
//Check whether a value exists.
//Sort numeric values.
//Display the number of elements.
//Challenge: Explain why using ArrayList can cause boxing/unboxing and type-safety issues compared with List<T>.

public partial class _Default : System.Web.UI.Page
{
    int num;
    static ArrayList orders = new ArrayList() {
        101, "Saniya", 2 , 799.99 };

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        orders.Add(txtData.Text);
        lblOutput.Text = "Data Added Successfully";
    }

    protected void btnDisplay_Click(object sender, EventArgs e)
    {
        lblOutput.Text = "";
        foreach(object o in orders)
        {
            lblOutput.Text += o + " ";
        }
    }

    protected void btnInsert_Click(object sender, EventArgs e)
    {
        num = Convert.ToInt32(txtIndex.Text);

        if(orders.Contains(num))
        {
            orders.Insert(num, txtValue.Text);
            lblOtherOutput.Text = "Data Added Successfully: " + orders[num];
        }
        else
        {
            lblOtherOutput.Text = "Given Index Not Found";
        }        
    }

    protected void btnDelIndx_Click(object sender, EventArgs e)
    {
        num = Convert.ToInt32(txtIndex.Text);

        if (orders.Contains(num))
        {
            orders.RemoveAt(num);
            lblOtherOutput.Text = "Deleted Successfully";
        }
        else
        {
            lblOtherOutput.Text = "Invalid Index Entered";
        }
    }

    protected void btnDelVal_Click(object sender, EventArgs e)
    {
        if (orders.Contains(txtValue.Text))
        {
            orders.Remove(txtValue.Text);
            lblOtherOutput.Text = "Deleted Successfully";
        }
        else
        {
            lblOtherOutput.Text = "Invalid Index Entered";
        }
    }

    protected void btnCheck_Click(object sender, EventArgs e)
    {
        if (orders.Contains(txtValue.Text))
        {
            lblOtherOutput.Text = "Value Exists";
        }
        else
        {
            lblOtherOutput.Text = "Invalid Value Entered";
        }
    }
}
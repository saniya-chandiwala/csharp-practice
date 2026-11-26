using CustRegLib;
using System;

public partial class RegForm : System.Web.UI.Page
{
    Customer customer;
    long num;

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnCreate_Click(object sender, EventArgs e)
    {
        try
        {
            if (chkName.Checked && chkEmail.Checked && chkNumber.Checked && chkAddress.Checked)
            {
                num = Convert.ToInt64(txtNumber.Text);

                customer = new Customer(txtName.Text, txtEmail.Text, num, txtAddress.Text);

                lblDetails.Text = "Customer created successfully" +
                    "<br>Name : " + txtName.Text +
                    "<br>Email : " + txtEmail.Text+
                    "<br>Contact Number : " + num +
                    "<br>Address : " + txtAddress.Text; 
            }
            else if (chkName.Checked && chkEmail.Checked && chkNumber.Checked)
            {
                num = Convert.ToInt64(txtNumber.Text);

                customer = new Customer(txtName.Text, txtEmail.Text, num);

                lblDetails.Text = "Customer created successfully" +
                    "<br>Name : " + txtName.Text +
                    "<br>Email : " + txtEmail.Text +
                    "<br>Contact Number : " + num;
            }
            else if (chkName.Checked && chkEmail.Checked)
            {
                customer = new Customer(txtName.Text, txtEmail.Text);

                lblDetails.Text = "Customer created successfully" +
                    "<br>Name : " + txtName.Text +
                    "<br>Email : " + txtEmail.Text;
            }
            else if (chkName.Checked)
            {
                customer = new Customer(txtName.Text);

                lblDetails.Text = "Customer created successfully" +
                    "<br>Name : " + txtName.Text;
            }
        }
        catch(Exception ex)
        {
            Response.Write(ex.Message);
        }
    }

}
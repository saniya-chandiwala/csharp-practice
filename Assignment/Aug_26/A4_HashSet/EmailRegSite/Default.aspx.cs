using EmailRegLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    string enteredEmail;
    EmailData data;
    HashSet<string> emails;

    protected void Page_Load(object sender, EventArgs e)
    {
        data = new EmailData();
        emails = data.GetHashSetData();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        enteredEmail = txtEmail.Text;
        if (emails.Contains(enteredEmail))
        {
            lblOutput.Text = "Email Already Exists";
        }
        else
        {
            emails.Add(enteredEmail);
            lblOutput.Text = "Email Added Successfully: " + enteredEmail + "<br/>Number Of Emails: " + emails.Count;
        }

    }

    protected void btnDisp_Click(object sender, EventArgs e)
    {

        lblDisp.Text = "Number Of Emails: " + emails.Count + "<br/>";
        foreach (string id in emails)
        {
            lblDisp.Text += id + "<br/>";
        }
    }

    protected void btnCheck_Click(object sender, EventArgs e)
    {
        enteredEmail = txtEmail.Text;
        if (emails.Contains(enteredEmail))
        {
            lblOutput.Text = "Email Already Exists";
        }
        else
        {
            lblOutput.Text = "Email Does Not Exist";
        }
    }

    protected void btnRemove_Click(object sender, EventArgs e)
    {
        enteredEmail = txtEmail.Text;
        if (emails.Contains(enteredEmail))
        {
            emails.Remove(enteredEmail);
            lblOutput.Text = "Email Removed Successfully";
        }
        else
        {
            lblOutput.Text = "Email Does Not Exist";
        }
    }
}
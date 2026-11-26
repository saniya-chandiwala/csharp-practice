using EmpInfoLib;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    int id;
    string name;

    EmpsData data;
    Hashtable emps;

    protected void Page_Load(object sender, EventArgs e)
    {
        data = new EmpsData();
        emps = data.GetHashTableData();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        id = Convert.ToInt32(txtId.Text);
        name = txtName.Text;

        if (!emps.ContainsKey(id))
        {
            emps.Add(id, name);
            lblOutput.Text = "Employee Added Successfully";
        }
        else
        {
            lblOutput.Text = "Employee Already Exists";
        }

    }

    protected void btnDisplay_Click(object sender, EventArgs e)
    {
        lblOutput.Text = "";
        foreach (DictionaryEntry emp in emps)
        {
            lblOutput.Text += "Employee Id: " + emp.Key + " Employee Name: " + emp.Value + "<br/>";
        }
    }

    protected void btnEmpId_Click(object sender, EventArgs e)
    {
        id = Convert.ToInt32(txtId.Text);

        if (emps.ContainsKey(id))
        {
            lblOutput.Text = "Employee Id: " + id + "<br/>Employee Name: " + emps[id];
        }
        else
        {
            lblOutput.Text = "Employee Not Found";
        }

    }

    protected void btnUpdName_Click(object sender, EventArgs e)
    {
        id = Convert.ToInt32(txtId.Text);
        name = txtName.Text;

        if (emps.ContainsKey(id))
        {
            emps[id] = name;
            lblOutput.Text = "Employee Name Updated <br/>Employee Name: " + emps[id];
        }
        else
        {
            lblOutput.Text = "Employee Not Found";
        }
    }

    protected void btnRemove_Click(object sender, EventArgs e)
    {
        id = Convert.ToInt32(txtId.Text);

        if (emps.ContainsKey(id))
        {
            emps.Remove(id);
            lblOutput.Text = "Employee Removed";
        }
        else
        {
            lblOutput.Text = "Employee Not Found";
        }
    }

    protected void btnChk_Click(object sender, EventArgs e)
    {
        id = Convert.ToInt32(txtId.Text);

        if (emps.ContainsKey(id))
        {
            lblOutput.Text = "Employee Exists";
        }
        else
        {
            lblOutput.Text = "Employee Not Found";
        }
    }
}
using System;
using System.Collections.Generic;
using SalMngmtLib;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    EmpDictionary details;
    Dictionary<int, double> emps;
    int id;
    double sal;

    protected void Page_Load(object sender, EventArgs e)
    {
        details = new EmpDictionary();
        emps = details.GetEmpDictionary();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        if (emps.Count == 0)
        {
            emps.Add(101, 160000);
            emps.Add(102, 20000);
            emps.Add(103, 60000);
            emps.Add(104, 18000);
            emps.Add(105, 80000);

            lblDisp.Text = "Employees Added Successfully";
        }
        else
        {
            lblDisp.Text = "Employees Already Added";
        }
    }

    protected void btnDisp_Click(object sender, EventArgs e)
    {
        lblDisp.Text = "";
        foreach (KeyValuePair<int, double> emp in emps)
        {
            lblDisp.Text += "ID: " + emp.Key + " Salary: " + emp.Value + "<br/>";
        }
    }

    protected void btnSal_Click(object sender, EventArgs e)
    {
        id = Convert.ToInt32(txtId.Text);

        if (emps.TryGetValue(id, out sal))
        {
            lblOutput.Text = "Employee Salary: " + sal;
        }
        else
        {
            lblOutput.Text = "Employee Not Found";
        }
    }

    protected void btnExist_Click(object sender, EventArgs e)
    {
        id = Convert.ToInt32(txtId.Text);

        if (emps.ContainsKey(id))
        {
            lblOutput.Text = "Employee Exists";
        }
        else
        {
            lblOutput.Text = "Employee Does Not Exist";
        }
    }

    protected void btnUpdateSal_Click(object sender, EventArgs e)
    {
        id = Convert.ToInt32(txtId.Text);
        sal = Convert.ToDouble(txtSal.Text);

        if (emps.ContainsKey(id))
        {
            lblOp.Text = "Previous Salary: " + emps[id] + "<br/>";
            emps[id] = emps[id] + sal;
            lblOp.Text += "Updated Salary: " + emps[id];
        }
        else
        {
            lblOp.Text = "Employee Not Found";
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

    protected void btnAvg_Click(object sender, EventArgs e)
    {
        foreach (double s in emps.Values)
        {
            sal += s;
        }
        sal = sal / emps.Count;
        lblAvg.Text = "Average Salary: " + sal;
    }

    protected void btnGreater_Click(object sender, EventArgs e)
    {
        foreach (KeyValuePair<int, double> emp in emps)
        {
            if (emp.Value > 50000)
            {
                lblGreater.Text += "ID: " + emp.Key + " Salary: " + emp.Value + "<br/>";
            }
        }
    }

}

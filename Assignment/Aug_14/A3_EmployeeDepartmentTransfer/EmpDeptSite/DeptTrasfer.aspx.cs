using EmpDeptLib;
using System;

public partial class DeptTrasfer : System.Web.UI.Page
{
    Employee emp;
    EmpTransfer transfer;
    int id;

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnTransfer_Click(object sender, EventArgs e)
    {
        try
        {
            transfer = new EmpTransfer();

            id = Convert.ToInt32(ddlEmps.SelectedValue);

            emp = transfer.TransferEmployee(id);

            if (emp != null)
            {
                lblTransfer.Text = "Employee Succesfully Transfered<br>" + "<br>Employee Id: " + emp.EmpId + "<br>Employee Name: " + emp.EmpName + "<br>Employee Dept: " + emp.EmpDept;
            }
            else
            {
                lblTransfer.Text = "Employee Cannot Be Transfered";
            }
        }
        catch(Exception ex)
        {
            Response.Write(ex.Message);
        }
    }       
}
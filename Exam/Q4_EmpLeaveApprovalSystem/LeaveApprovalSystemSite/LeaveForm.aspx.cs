using LeaveApprovalSystemLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

#region 
///<summary>
/// Q4. Employee Leave Approval System 
/// A company wants to develop an Employee Leave Management System.
/// 
///Employees can apply for different types of leave such as Casual Leave, Sick Leave, and Paid Leave.
/// 
/// The company has different authorities responsible for processing leave requests.
///  Although each authority performs the approval process differently, the application should interact with them through a common contract.
/// 
/// For example:
/// •	A Team Lead can approve normal leave requests within the permitted limit.
/// •	An HR Manager can approve longer leave requests.
/// •	A Department Head may be required for special or extended leave requests.
/// 
/// The company wants the system to be flexible so that a new type of leave approver can be introduced in the future 
/// without changing the existing leave-processing logic.
/// 
/// Scenario:
/// Design and implement a C# application using an appropriate Interface-based design for the Leave Management System.
/// The application should accept employee leave details and process the request through different approvers.
/// Demonstrate the processing of leave requests using at least three different implementations of the interface.
/// The main application should work with the interface rather than being tightly coupled to the concrete implementations.
/// Display an appropriate message indicating whether the leave request is approved or rejected by whom depending on the leave request.
///</summary>
#endregion

public partial class LeaveForm : System.Web.UI.Page
{
    ProcessLeave process;
    IApproveLeave approver;
    LeaveData data;
    string name, type;
    int days;

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        try
        {
            process = new ProcessLeave();

            name = txtName.Text;
            type = ddlType.SelectedValue;
            days = Convert.ToInt32(txtDays.Text);

            if (!string.IsNullOrWhiteSpace(name) && days > 0)
            {
                data = new LeaveData() { EmpName = name, LeaveType = type, NoOfDays = days };

                // selecting approver based on number of leave days
                if (days <= 2)
                {
                    approver = new TeamLead();
                }
                else if (days <= 5)
                {
                    approver = new HR();
                }
                else
                {
                    approver = new DeptHead();
                }

                // process the leave using the selected approver
                lblOutput.Text = process.Leave(approver, data);
            }
            else
            {
                lblOutput.Text = "Invalid data entered";
            }
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }
    }
}
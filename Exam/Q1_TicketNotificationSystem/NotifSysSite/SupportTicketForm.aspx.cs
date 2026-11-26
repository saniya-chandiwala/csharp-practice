using System;
using NotifSysLib;
using System.Web;

#region 
/// <summary>
/// Q1. IT Help Desk Ticket Notification System
/// 
/// A company wants to develop an IT Help Desk System to manage technical issues reported by its employees.
/// 
/// Whenever an employee faces a technical problem, they can raise a support ticket by providing details 
/// such as the employee name, issue description, and priority of the issue.
/// 
/// Once a ticket is created, the system should automatically notify the appropriate people.
/// 
/// The following notification rules apply:
/// •	The Support Team should be notified whenever a new support ticket is created.
/// •	The Employee should receive a confirmation notification after successfully raising the ticket.
/// •	If the ticket is marked as High Priority, the Team Lead should also be notified so that the issue can be handled on priority.
/// 
/// The system should support multiple subscribers to notifications. A subscriber should also be able to unsubscribe from a notification when it is no longer required.
/// </summary>
#endregion

public partial class SupportTicketForm : System.Web.UI.Page
{
    HelpDesk desk;
    Ticket ticket;
    Employee emp;
    SupportTeam team;
    TeamLead lead;

    string name, desc;

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        try
        {
            desk = new HelpDesk();
            emp = new Employee();
            team = new SupportTeam();
            lead = new TeamLead();

            name = txtName.Text;
            desc = txtDesc.Text;

            // validating input fields
            if (!string.IsNullOrWhiteSpace(name) && !string.IsNullOrWhiteSpace(desc))
            {
                ticket = new Ticket() { EmpName = name, IssueDesc = desc, Priority = ddlPriority.SelectedValue };

                // subscribing
                desk.TicketEvent += emp.Notify;
                desk.TicketEvent += team.Notify;
                desk.TicketEvent += lead.Notify;

                // unsubscribing
                if (chkEmp.Checked)
                {
                    desk.TicketEvent -= emp.Notify;
                }
                if (chkSupportTeam.Checked)
                {
                    desk.TicketEvent -= team.Notify;
                }
                if (chkTeamLead.Checked)
                {
                    desk.TicketEvent -= lead.Notify;
                }

                // raising event
                desk.OnTicketCreated(ticket);
            }
            else
            {
                Response.Write("Enter vaild details");
            }
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }
    }
}

/// <summary>
/// subscriber classes
/// </summary>

public class SupportTeam
{
    public void Notify(Ticket ticket)
    {
        HttpContext.Current.Response.Write("<br/> Support Team Notification: New support ticket raised <br/>");
    }
}

public class Employee
{
    public void Notify(Ticket ticket)
    {
        HttpContext.Current.Response.Write("<br/> Employee Notification: Employee " + ticket.EmpName + " support ticket has been successfully raised<br/>");
    }
}

public class TeamLead
{
    public void Notify(Ticket ticket)
    {
        // notified only for High Priority tickets
        if (ticket.Priority == "High")
        {
            HttpContext.Current.Response.Write("<br/> Team Lead Notification: High Priority ticket has been raised<br/>");
        }
    }
}


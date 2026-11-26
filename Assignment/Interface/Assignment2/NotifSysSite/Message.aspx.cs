using System;
using NotifSysLib;


public partial class Message : System.Web.UI.Page
{
    INotification notification; 

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSend_Click(object sender, EventArgs e)
    {
        try
        {
            switch (ddlNotification.SelectedValue)
            {
                case "WhatsApp":
                    notification = new WhatsAppNotification();
                    break;

                case "SMS":
                    notification = new SMSNotification();
                    break;

                case "Email":
                    notification = new EmailNotification();
                    break;
            }

            lblNotif.Text = notification.SendNotification(txtMessage.Text);
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }
    }
}
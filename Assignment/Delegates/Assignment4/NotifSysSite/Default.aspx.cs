using System;
using NotifSysLib;

public partial class _Default : System.Web.UI.Page
{
    Notifications n;
    NotificationHandler del;


    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSend_Click(object sender, EventArgs e)
    {
        n = new Notifications();

        del = n.SendEmail;
        del += n.SendSMS;
        del += n.SendWhatsApp;

        del(txtMsg.Text);

        lblOutput.Text = n.Result;
    }
}
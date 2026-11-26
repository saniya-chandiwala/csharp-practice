namespace NotifSysLib
{
    public delegate void NotificationHandler(string message);

    public class Notifications
    {
        public string Result { get; set; }

        public void SendEmail(string message)
        {
            Result += "Email Sent: " + message + "<br/>";
        }

        public void SendSMS(string message)
        {
            Result += "SMS Sent: " + message + "<br/>";
        }

        public void SendWhatsApp(string message)
        {
            Result += "WhatsApp Sent: " + message + "<br/>";
        }

    }
}

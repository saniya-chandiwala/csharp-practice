//An application needs to send notifications through
//    Email, SMS, and WhatsApp.

//Create an interface INotification with:

//SendNotification(string message)
//Create classes:

//EmailNotification
//SMSNotification
//WhatsAppNotification
//Question: Write a program where the user can select a 
//    notification type and send a message using an interface reference.

namespace NotifSysLib
{
    public interface INotification
    {
        string SendNotification(string message);
    }
}

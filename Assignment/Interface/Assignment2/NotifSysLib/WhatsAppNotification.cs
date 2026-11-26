using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotifSysLib
{
    public class WhatsAppNotification : INotification
    {
        public string SendNotification(string message)
        {
            return "WhatsApp Notification: " + message;
        }
    }
}

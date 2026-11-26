using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotifSysLib
{
    public class EmailNotification : INotification
    {
        public string SendNotification(string message)
        {
            return "Email Notification: " + message;
        }
    }
}

using System.Web;

namespace NotifSysLib
{
    // delegate
    public delegate void TicketDel(Ticket ticket);

    public class HelpDesk
    {
        //event
        public event TicketDel TicketEvent;

        // method which raises event
        public void OnTicketCreated(Ticket ticket)
        {
            // check subscriber is attached to the event
            if (TicketEvent != null)
            {
                // notifying all subscribers
                TicketEvent(ticket);
            }
            else
            {
                HttpContext.Current.Response.Write("Event is null");
            }
        }
    }
}


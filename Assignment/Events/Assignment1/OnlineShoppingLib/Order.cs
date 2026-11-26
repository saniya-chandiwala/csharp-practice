using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace OnlineShoppingLib
{
    public delegate void OrderPlacedDel(Order o);
    public class Order
    {
        public int OrderId { get; set; }
        public string CustomerName { get; set; }
        public double Amount { get; set; }

        public event OrderPlacedDel OrderPlacedEvent;

        public void PlaceOrder(Order o)
        {
            //checking whether handler attach to event or not,if not in that case event is null
            if (OrderPlacedEvent != null)
            {
                //raising event
                OrderPlacedEvent(o);
            }
            else
            {
                HttpContext.Current.Response.Write("Event Handler not attach to event");
            }
        }
    }
}

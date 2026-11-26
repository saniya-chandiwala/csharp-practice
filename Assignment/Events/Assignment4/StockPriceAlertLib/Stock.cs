using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

//4. Stock Price Alert

//A stock market application monitors stock prices.

//When the price of a stock changes:

//Notify the user.
//Notify the investment advisor.
//If the price goes below ₹500, send a warning.
//Requirements:

//Create a Stock class.
//Create PriceChanged event.
//Raise the event whenever the price changes.
//Create multiple subscribers.

namespace StockPriceAlertLib
{
    public delegate void PriceChangedDel(Stock stock);

    public class Stock
    {
        public string StockName { get; set; }
        public double Price { get; set; }

        public event PriceChangedDel PriceChangedEvent;

        public void ChangePrice()
        {
            if(Price > 500)
            {
                if (PriceChangedEvent != null)
                {
                    PriceChangedEvent(this);
                }
                else
                {
                    HttpContext.Current.Response.Write("Event Handler not attached");
                }
            }


            
        }
    }
}

//An e-commerce application performs multiple operations when an order is placed.

//Create a class Order with:

//OrderId
//ProductName
//Amount
//Create methods:

//GenerateInvoice()
//SendConfirmationEmail()
//UpdateInventory()
//Create a delegate:

//delegate void OrderHandler();
//Assignment
//Create a multicast delegate that calls all three methods when an order is placed.

namespace OrderProcessingLib
{
    public delegate void OrderHandler();

    public class Order
    {
        public int OrderId { get; set; }
        public string ProductName { get; set; }
        public double Amount { get; set; }

        public string Result { get; set; }

        public void GenerateInvoice()
        {
            Result += "Invoice generated for order: " + OrderId + "<br/>";
        }

        public void SendConfirmationEmail()
        {
            Result += "Confirmation email sent<br/>";
        }

        public void UpdateInventory()
        {
            Result += "Inventory updated for product: " + ProductName + "<br/>";
        }
    }
}

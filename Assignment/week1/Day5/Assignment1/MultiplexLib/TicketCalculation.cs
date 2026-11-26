namespace MultiplexLib
{
    #region
    /// <summary>
    /// static class to calculate cost of ticket
    /// </summary>
    #endregion
    public static class TicketCalculation
    {
        const double gst = 0.18;

        // initial cost
        public static double SubTotal(double price, int quantity)
        {
            return price * quantity;
        }

        // taxed amount
        public static double Gst(double price, int quantity)
        {
            return SubTotal(price, quantity) * gst;
        }

        // final payable amount
        public static double Total(double price, int quantity)
        {
            return SubTotal(price, quantity) + Gst(price, quantity);
        }

    }
}

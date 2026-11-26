namespace PaymentSysLib
{
    public abstract class Payment
    {
        public int TransactionId { get; set; }
        public double Amount { get; set; }

        public abstract double MakePayment();

        public string GenerateReceipt()
        {
            return "Transaction Id: " + TransactionId + "<br>Amount: " + Amount;
        }
    }
}

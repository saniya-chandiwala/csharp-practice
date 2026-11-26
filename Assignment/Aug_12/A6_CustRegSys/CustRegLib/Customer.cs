namespace CustRegLib
{
    public class Customer
    {
        public string CustName { get; set; }
        public string CustEmail { get; set; }
        public long CustNumber { get; set; }
        public string CustAddress { get; set; }

        public Customer(string name)
        {
            CustName = name;
        }

        public Customer(string name, string email)
        {
            CustName = name;
            CustEmail = email;
        }

        public Customer(string name, string email, long number)
        {
            CustName = name;
            CustEmail = email;
            CustNumber = number;
        }

        public Customer(string name, string email, long number, string address)
        {
            CustName = name;
            CustEmail = email;
            CustNumber = number;
            CustAddress = address;
        }

    }
}

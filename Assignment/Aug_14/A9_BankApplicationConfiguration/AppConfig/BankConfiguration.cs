namespace AppConfig
{
    public static class BankConfiguration
    {
        static string bankName;
        static double miniBalance;
        static double maxWithdrawalLimit;
        static int appVersion;

        static BankConfiguration()
        {
            bankName = "Axis";
            miniBalance = 5000;
            maxWithdrawalLimit = 1000;
            appVersion = 11;
        }

        public static string DisplayConfiguration()
        {
            return "Bank Name: " + bankName + "<br>Minimum Balance: " + miniBalance + "<br>Maximum Withdrawal Limit: " + maxWithdrawalLimit + "<br>Application Version: " + appVersion;
        }
    }
}

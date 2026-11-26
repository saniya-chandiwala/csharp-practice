namespace ConfigLib
{
    public class Config
    {
        public static string bankName;
        public static double minBal;
        public static double maxLimit;
        public static int appVersion;

        static Config()
        {
            bankName = "Axis Bank";
            minBal = 5000;
            maxLimit = 1000;
            appVersion = 11;
        }
    }
}

namespace TempConvLib
{
    public static class TemperatureConverter
    {
        public static double CelsiusToFahrenheit(double temp)
        {
            return (temp * 9 / 5) + 32;
        }

        public static double FahrenheitToCelsius(double temp)
        {
            return (temp - 32) * 5 / 9;
        }
    }
}

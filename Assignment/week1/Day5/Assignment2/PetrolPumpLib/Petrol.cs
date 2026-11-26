namespace PetrolPumpLib
{
    #region
    /// <summary>
    /// class with fixed price and bill calculation method
    /// </summary>
    #endregion
    public class Petrol
    {
        public string CustomerName { get; set; }
        public double LitresPurchased { get; set; }

        const double costPerLitre = 94.7;

        // method to calculate cost
        public double BillGeneration()
        {
            return LitresPurchased * costPerLitre;
        }
    }
}

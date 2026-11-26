namespace RentalSysLib
{
    public class Car : IRentable
    {
        public int VehicleNumber { get; set; }
        public string Model { get; set; }
        public double RentPerDay { get; set; }
        double rent;

        public double CalculateRent(int days)
        {
            rent = (RentPerDay + (RentPerDay * 0.10)) * days;
            return rent;
        }

        public string DisplayVehicleDetails()
        {
            return "Rented Car Details" + "<br/>Number: " + VehicleNumber + "<br/>Model: " + Model + "<br/>Rent Per Day: " + RentPerDay + "<br/>Total Rent: " + rent;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalSysLib
{
    public class Bike : IRentable
    {
        public int VehicleNumber { get; set; }
        public string Model { get; set; }
        public double RentPerDay { get; set; }
        double rent;

        public double CalculateRent(int days)
        {
            rent = RentPerDay * days;
            return rent;
        }

        public string DisplayVehicleDetails()
        {
            return "Rented Bike Details" + "<br/>Number: " + VehicleNumber + "<br/>Model: " + Model + "<br/>Rent Per Day: " + RentPerDay + "<br/>Total Rent: " + rent;
        }
    }
}

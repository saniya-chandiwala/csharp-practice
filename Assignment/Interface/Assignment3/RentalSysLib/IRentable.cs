//Vehicle Rental System

//A vehicle rental application rents Cars and Bikes.

//Create an interface IRentable with:

//CalculateRent(int days)
//DisplayVehicleDetails()
//Create:

//Car
//Bike
//The rental calculation should be different for each vehicle.

//Question: Implement the interface and demonstrate 
//    runtime polymorphism using an interface reference.

namespace RentalSysLib
{
    public interface IRentable
    {
        double CalculateRent(int days);
        string DisplayVehicleDetails();
    }
}

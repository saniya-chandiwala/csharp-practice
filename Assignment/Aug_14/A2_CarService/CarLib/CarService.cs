namespace CarLib
{
    public class CarService
    {

        Car[] cars;
        
        public CarService()
        {
            cars = new Car[]{
                new Car() { CarNumber = 101 , CarModel = "Mercedes", ServiceCost = 10000 },
                new Car() { CarNumber = 102, CarModel = "Honda", ServiceCost = 5000 },
                new Car() { CarNumber = 103, CarModel = "Nissan", ServiceCost = 1000 }
            };
        }
        
        public double GetCar(int num)
        {
            foreach (Car c in cars)
            {
                if (c.CarNumber == num)
                {
                    return c.ServiceCost + ;
                }
            }
        }
    }
}

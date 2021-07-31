using System;

namespace Chapter12
{
    public class Vehicle
    {
        public string model;
        public string manufacturer;
        public int numOfDoors;
        public int numOfWheels;
    }
    public class Motor
    {
        public int power;
        public double displacement;
    }
    public class Car
    {
        public static int numberOfCars;
        public string licensePlate;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter information about vehicle");
            Vehicle myCar = new Vehicle();
            Console.Write("Model = ");
            myCar.model = Console.ReadLine();

            Console.Write("Manufacturer = ");
            myCar.manufacturer = Console.ReadLine();

            Console.Write("Number of Doors = ");
            string doors = Console.ReadLine();
            myCar.numOfDoors = Convert.ToInt32(doors);

            Console.Write("Number of Wheels = ");
            string Wheels = Console.ReadLine();
            myCar.numOfWheels = Convert.ToInt32(Wheels);

            Console.WriteLine("your car info:\nCar model :"
                + myCar.model + "\nCar Manufacturer: " + myCar.manufacturer
                + "\nNumber of Doors {0}\nNumber of Wheels {1}"
                , myCar.numOfDoors, myCar.numOfWheels);

        }
    }
}

using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {

            var carLot = new CarLot();
            //TODO


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //dot notation
            var charger = new Car();
            charger.Make = "dodge";
            charger.Model = "charger";
            charger.Year = 1967;
            charger.EnginNoise = "Vroom";
            charger.HonkNoise = "beep beep";
            charger.IsDrivable = false;

            carLot.ParkingLot.Add(charger);
            //object initializer syntax
            var honda = new Car()
            {
                Make = "Honda",
                Model = "Accord",
                Year = 2021, EnginNoise = "Rumble", HonkNoise = "honk", IsDrivable = true };
            carLot.ParkingLot.Add(honda);

            var camry = new Car(2021, "Toyota", "Camry", "Vroom", "beep", false);
            carLot.ParkingLot.Add(camry);
            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            carLot.ParkingLot = new List<Car>() { charger, honda };
            foreach (var car in carLot.ParkingLot)
            {
                Console.WriteLine($"this is a {car.Make}{car.Model} made is the year {car.Year}");
                car.MakeEngineNoise(car.EnginNoise);
                car.MakeHonkNoise(car.HonkNoise);
            }
        }
    }
}

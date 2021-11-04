using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var lot = new CarLot();
            
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car
            var myTruck = new Car();
            myTruck.Make = "Ford";
            myTruck.Model = "F150";
            myTruck.Year = 2021;
            myTruck.EngineNoise = "Vroooom";
            myTruck.HonkNoise = "Beep, Beep.";
            myTruck.IsDrivable = true;

            lot.Cars.Add(myTruck);
            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car
            var sarahsCar = new Car()
            {
                Year = 2021,
                Make = "Tesla",
                Model = "cyber Truck",
                EngineNoise = "Its Quite",
                HonkNoise = "Varuugahhh",
                IsDrivable = true,


            };
            lot.Cars.Add(sarahsCar);
            //*************BONUS X 2*************//
            var JeremyCar = new Car(2021, "Ford", "F350", "Loud", "Beep", true);

            lot.Cars.Add(JeremyCar);
            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            foreach (var car in lot.Cars)
            {
                Console.WriteLine($"Year: {car.Year} Make: {car.Make} Model: {car.Model}");
            }
        }
    }
}

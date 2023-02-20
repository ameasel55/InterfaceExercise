using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values

           var car1 = new Car();
            car1.NumberOfDoors = 4;
            car1.HasCupholders = true;
            car1.NumberOfSeats = 5;
            car1.HasSunroof = false;
            car1.Slogan = "You gotta drive it to believe it!";
            car1.IsWorldwide = true;
            car1.HorsePower = 200;
            car1.FoldFlatSeats = true;

           var truck1 = new Truck();
            truck1.NumberOfDoors = 2;
            truck1.HasCupholders = false;
            truck1.NumberOfSeats = 3;
            truck1.HasSunroof = false;
            truck1.Slogan = "This aint your daddy's truck";
            truck1.IsWorldwide = false;
            truck1.BedSize = "175″ L x 65-67″ W x 62-67″ H";
            truck1.FourWheelDrive = true;

            var suv1 = new SUV();
            suv1.NumberOfDoors = 6;
            suv1.HasCupholders = true;
            suv1.NumberOfSeats = 8;
            suv1.HasSunroof = true;
            suv1.Slogan = "Comfort never felt so comfy";
            suv1.IsWorldwide = true;
            suv1.CargoHoldSize = "14.4 feet";
            suv1.HasSeatWarmer = true;



            Console.WriteLine("~THE CAR~");
            Console.WriteLine($"Number of doors: {car1.NumberOfDoors}");
            Console.WriteLine($"T/F - Does this car have cupholders: {car1.HasCupholders}");
            Console.WriteLine($"Number of seats: {car1.NumberOfSeats}");
            Console.WriteLine($"T/F - Does this car have a sunroof: {car1.HasSunroof}");
            Console.WriteLine($"Slogan for this car: {car1.Slogan}");
            Console.WriteLine($"T/F - Is this car a worldwide brand: {car1.IsWorldwide}");
            Console.WriteLine($"What is the horsepower for this car: {car1.HorsePower}");
            Console.WriteLine($"T/F - Does the backseat fold flat for more room: {car1.FoldFlatSeats}");
            Console.WriteLine();
            Console.WriteLine("~~~~~~~~~~~~~");
            Console.WriteLine();

            Console.WriteLine("~THE TRUCK~");
            Console.WriteLine($"Number of doors: {truck1.NumberOfDoors}");
            Console.WriteLine($"T/F - Does this truck have cupholders: {truck1.HasCupholders}");
            Console.WriteLine($"Number of seats: {truck1.NumberOfSeats}");
            Console.WriteLine($"T/F - Does this truck have a sunroof: {truck1.HasSunroof}");
            Console.WriteLine($"Slogan for this truck: {truck1.Slogan}");
            Console.WriteLine($"T/F - Is this truck a worldwide brand: {truck1.IsWorldwide}");
            Console.WriteLine($"What is the bedsize for this truck: {truck1.BedSize}");
            Console.WriteLine($"T/F - Does this truck have 4WD: {truck1.FourWheelDrive}");
            Console.WriteLine();
            Console.WriteLine("~~~~~~~~~~~~~");
            Console.WriteLine();

            Console.WriteLine("~THE SUV~");
            Console.WriteLine($"Number of doors: {suv1.NumberOfDoors}");
            Console.WriteLine($"T/F - Does this SUV have cupholders: {suv1.HasCupholders}");
            Console.WriteLine($"Number of seats: {suv1.NumberOfSeats}");
            Console.WriteLine($"T/F - Does this SUV have a sunroof: {suv1.HasSunroof}");
            Console.WriteLine($"Slogan for this SUV: {suv1.Slogan}");
            Console.WriteLine($"T/F - Is this SUV a worldwide brand: {suv1.IsWorldwide}");
            Console.WriteLine($"What is the cargo hold size for this SUV: {suv1.CargoHoldSize}");
            Console.WriteLine($"T/F - Does this SUV have a seat warmer: {suv1.HasSeatWarmer}");
            Console.WriteLine();
            Console.WriteLine("~~~~~~~~~~~~~");
        }
    }
}

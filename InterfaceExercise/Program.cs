using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany --- Done

            //Create 3 classes called Car , Truck , & SUV --- Done

            //In your IVehicle ---/ DONE

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany ---Done

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes ----- Done

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values
             
            Truck GavinsTruck = new Truck() { bedSize = "Large", forWheelDrive = true};

            SUV GavinsSUV = new SUV() { cargoSize = "Small", fourthRowSeating = false };

            Car GavinsCar = new Car() { trunkSize = "Large", motorPos = "Front" };

            List < IVehicle> vehicles = new List<IVehicle>() ;

            vehicles.Add(GavinsTruck);
            vehicles.Add(GavinsSUV);
            vehicles.Add(GavinsCar);

            foreach (var car in vehicles)
            {
                Console.WriteLine($"Collor: {car.color}, MODEL: {car.Model}, NUmber Of Doors: {car.NUmberOfDoors}, Number of Whells: {car.NumberOfWhells}");
                Console.WriteLine("/////////////////////////////////////////");
            }

           

            
        }
    }
}

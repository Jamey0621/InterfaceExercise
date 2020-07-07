using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class Truck : ICompany , IVehicle
    {
        public string bedSize { get; set; }


        public bool forWheelDrive { get; set; }
        string ICompany.Logo { get; set; } = "Fords Logo";
        string ICompany.CompName { get; set; } = "FOrd";
        int IVehicle.NumberOfWhells { get; set; } = 4;
        int IVehicle.NUmberOfDoors { get; set; } = 2;
        string IVehicle.Model { get; set; } = "Ford";
        string IVehicle.color { get; set; } = "Red";
    }
}

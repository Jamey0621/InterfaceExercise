using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class Car : IVehicle , ICompany
    {
        public string trunkSize { get; set; }

        public string motorPos { get; set; }

        string ICompany.Logo { get; set; } = "|||||___----|||";
        string ICompany.CompName { get; set; } = "buic";
        int IVehicle.NumberOfWhells { get; set; } = 4;
        int IVehicle.NUmberOfDoors { get; set; } = 4;
        string IVehicle.Model { get; set; } = "Lacern";
        string IVehicle.color { get; set; } = "Brown";
    }



}


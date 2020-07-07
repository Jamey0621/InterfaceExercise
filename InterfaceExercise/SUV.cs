using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class SUV : ICompany, IVehicle
    {
        public string cargoSize { get; set; }

        public bool fourthRowSeating { get; set; }

        string ICompany.Logo { get; set; } = "SUV LOGO";
        string ICompany.CompName { get; set; } = "SUV COMPANY";
        int IVehicle.NumberOfWhells { get; set; } = 4;
        int IVehicle.NUmberOfDoors { get; set; } = 4;
        string IVehicle.Model { get; set; } = "A SUV MODEL";
        string IVehicle.color { get; set; } = "BLUE";
    }
}


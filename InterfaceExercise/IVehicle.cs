using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
  public  interface IVehicle
    {
        public int NumberOfWhells { get; set; }
        public int NUmberOfDoors { get; set; }

        public string Model { get; set; }

        public string color { get; set; }

    }
}

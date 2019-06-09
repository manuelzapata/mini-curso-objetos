using System;
using System.Collections.Generic;
using System.Text;

namespace Course.OOP.ProgramAbstraction.Example
{
    class Program
    {

        public static void main(string[] args) {

            TripCalculator calculator = new TripCalculator();

            var destinations = new List<Destination>();
            destinations.Add(new Destination { Name = "Bali" });
            destinations.Add(new Destination { Name = "Buenos Aires" });
            destinations.Add(new Destination { Name = "Barcelona" });

            calculator.CalculatePrice(destinations);

        }

    }
}

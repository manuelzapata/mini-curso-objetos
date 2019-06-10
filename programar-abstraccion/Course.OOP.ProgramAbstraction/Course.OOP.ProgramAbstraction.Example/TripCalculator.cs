using System;
using System.Collections.Generic;

namespace Course.OOP.ProgramAbstraction.Example
{
    public class TripCalculator
    {

        /**El parámetro cierra la implementación solo a parámetros List<Destination>*/
        public decimal CalculatePrice(IList<Destination> destinations) {

            return 1000;

        }

    }
}

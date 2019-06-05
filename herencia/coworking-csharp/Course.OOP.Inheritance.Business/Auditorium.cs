using System;
using System.Collections.Generic;
using System.Text;

namespace Course.OOP.Inheritance.Business
{
    public class Auditorium: MeetingRoom
    {

        public Auditorium(String name, int chairs) : base(name, chairs) { }

        /*
        * Como el método en la clase padre no es abstracto, es opcional sobreescribirlo aquí.
        * */
        public override decimal CalculatePricePerDay()
        {
            Console.WriteLine("Ejecutando método en Auditorium");
            //Agregar un valor adicional.
            decimal basePrice = base.CalculatePricePerDay();
            decimal result = basePrice + 100;

            return result;
        }

    }
}

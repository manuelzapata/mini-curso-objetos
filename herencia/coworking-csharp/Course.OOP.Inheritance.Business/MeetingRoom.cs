using System;
using System.Collections.Generic;
using System.Text;

namespace Course.OOP.Inheritance.Business
{

    /*
    * Esta clase no es abstracta ni sealed.
    *
    * Se puede tanto heredar como crear clases hijas sin ningún problema.
    * */
    public class MeetingRoom : Space, ISchedulable
    {

        public MeetingRoom(String name, int chairs): base(name, chairs){}

        public override decimal CalculatePricePerDay()
        {
            Console.WriteLine("Ejecutando método en MeetingRoom");
            const decimal pricePerChair = 15;
            decimal price = pricePerChair * Chairs;
            return price;
        }

        /*
        * Este método viene de la interfaz Schedulable. Debe ser definido.
        * */
        public bool IsAvailable(DateTime start, DateTime end)
        {
            //Aquí se implementaría alguna lógica que validara la disponibilidad del espacio.
            return false;
        }
    }
}

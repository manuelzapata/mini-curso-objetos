using Course.OOP.Inheritance.Business;
using Course.OOP.Inheritance.Business.Media;
using System;
using System.Collections.Generic;

namespace Course.OOP.Inheritance.App
{
    class Program
    {
        static void Main(string[] args)
        {
            //Al descomentar la siguiente línea, habrá un error de compilación. No se pueden crear objetos de clases abstractas.
            //Space newSpace = new Space("Sala de juntas", 30);

            //HotDesk es una clase final. No se puede heredar, pero sí instanciar.

            HotDesk single = new HotDesk("Puesto 5");
            //A pesar de que el método getName fue definido en la clase base (Space), se puede acceder sin ningún problema.
            Console.WriteLine("Nombre del puesto:  " + single.Name);

            //Cualquier objeto de una clase que implemente ISchedulable se puede añadir a la lista.
            List<ISchedulable> list = new List<ISchedulable>();
            list.Add(new MeetingRoom("Sala creativa", 6));
            list.Add(new Auditorium("Auditorio Múltiple", 30));
            list.Add(new Speaker(500, true));
            list.Add(new VideoBeam("SVGA"));

            DateTime start = DateTime.Now;
            DateTime end = start.AddDays(1);

            foreach (ISchedulable item in list)
            {
                String className = item.GetType().Name;
                bool isAvailable = item.IsAvailable(start, end);
                Console.WriteLine(className + " is available: " + isAvailable);

                if (item is MeetingRoom) {
                    Console.WriteLine("Meeting room " + ((MeetingRoom)item).CalculatePricePerDay());
                }
            }
        }
    }
}

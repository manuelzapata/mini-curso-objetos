using System;

namespace Course.OOP.Inheritance.Business
{

    /*
    * Clase abstracta.
    *
    * Normalmente se utilizan para iniciar una jerarquía de clases, y definir los elementos comunes a todas las clases
    * que pertenezcan a esta.
    *
    * No se pueden crear objetos de esta clase.
    * */
    public abstract class Space
    {

        public string Name { get; private set; }
        public int Chairs { get; private set; }

        protected Space(String name, int chairs)
        {
            this.Name = name;
            this.Chairs = chairs;
        }

        public abstract decimal CalculatePricePerDay();


    }
}

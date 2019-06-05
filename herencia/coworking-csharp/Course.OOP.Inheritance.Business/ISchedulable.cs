using System;
using System.Collections.Generic;
using System.Text;

namespace Course.OOP.Inheritance.Business
{

    /*
    * Esta es una interfaz, no una clase. No se pueden crear objetos a partir de esta.
    *
    * Sirven para definir comportamientos que tendrán las clases.
    *
    * Es una alternativa a tener herencia múltiple.
    *
    * **/
    public interface ISchedulable
    {

        /*
        * Este método debe ser definido por todas las clases que implementen la interfaz.
        * */
        bool IsAvailable(DateTime start, DateTime end);

    }
}

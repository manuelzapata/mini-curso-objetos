using System;
using System.Collections.Generic;
using System.Text;

namespace Course.OOP.Inheritance.Business
{

    /*
    * Esta clase, al ser sealed, termina la jerarquía de clases. Es decir, esta clase no puede ser heredada.
    *
    * Sin embargo, se pueden crear objetos de esta clase sin ningún problema.
    *
    * Al igual que las clases, los métodos también pueden ser sealed.
    *
    * */
    public sealed class HotDesk : Space
    {

        //base() permite invocar el constructor de la clase base.
        public HotDesk(string name): base(name, 1) {}

        public override decimal CalculatePricePerDay()
        {
            //Los puestos flotantes tienen un precio fijo por día.
            return 10;
        }
    }

    //Crear una clase hija de HotDesk generaría error ya que es sealed. Descomenta las siguientes lineas para verlo.
    /*public class AnotherDesk: HotDesk {

        public AnotherDesk(String name): base(name) {}
    }*/
}

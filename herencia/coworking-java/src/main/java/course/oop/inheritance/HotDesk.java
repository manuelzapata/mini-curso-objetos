package course.oop.inheritance;

import java.math.BigDecimal;

/*
* Esta clase, al ser final, termina la jerarquía de clases. Es decir, esta clase no puede ser heredada.
*
* Sin embargo, se pueden crear objetos de esta clase sin ningún problema.
*
* Al igual que las clases, los métodos también pueden ser final.
*
* */
public final class HotDesk extends Space {

    public HotDesk(String name) {
        //super() permite invocar el constructor de la clase base.
        super(name, 1);
    }

    public BigDecimal calculatePricePerDay() {
        //Los puestos flotantes tienen un precio fijo por día.
        return new BigDecimal(10);
    }
}

//Crear una clase hija de HotDesk generaría error ya que es final. Descomenta las siguientes lineas para verlo.
/*public class AnotherDesk extends HotDesk {

    public AnotherDesk(String name) {
        super(name);
    }
}*/

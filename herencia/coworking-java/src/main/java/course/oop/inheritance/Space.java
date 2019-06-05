package course.oop.inheritance;

import java.math.BigDecimal;

/*
* Clase abstracta.
*
* Normalmente se utilizan para iniciar una jerarquía de clases, y definir los elementos comunes a todas las clases
* que pertenezcan a esta.
*
* No se pueden crear objetos de esta clase.
* */
public abstract class Space {

    private String name;
    private int chairs;

    protected Space(String name, int chairs) {
        this.name = name;
        this.chairs = chairs;
    }

    public abstract BigDecimal calculatePricePerDay();

    public String getName() {
        return name;
    }

    public int getChairs() {
        return chairs;
    }
}

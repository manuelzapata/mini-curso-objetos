package course.oop.inheritance;

import java.math.BigDecimal;

public class Auditorium extends MeetingRoom {

    public Auditorium(String name, int chairs) {
        super(name, chairs);
    }

    /*
    * Como el método en la clase padre no es abstracto, es opcional sobreescribirlo aquí.
    * */
    public BigDecimal calculatePricePerDay() {

        //Agregar un valor adicional.
        BigDecimal basePrice = super.calculatePricePerDay();
        BigDecimal result = basePrice.add(new BigDecimal(100));

        return result;
    }
}

package course.oop.inheritance;

import java.math.BigDecimal;
import java.time.LocalDateTime;

/*
* Esta clase no es abstracta ni final.
*
* Se puede tanto heredar como crear clases hijas sin ningún problema.
* */
public class MeetingRoom extends Space implements Schedulable {

    public MeetingRoom(String name, int chairs) {
        super(name, chairs);
    }

    public BigDecimal calculatePricePerDay() {
        final double pricePerChair = 15;
        BigDecimal price = new BigDecimal(pricePerChair * getChairs());
        return price;
    }

    /*
    * Este método viene de la interfaz Schedulable. Debe ser definido.
    * */
    public boolean isAvailable(LocalDateTime start, LocalDateTime end) {
        //Aquí se implementaría alguna lógica que validara la disponibilidad del espacio.
        return false;
    }
}

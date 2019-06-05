package course.oop.inheritance.app;

import course.oop.inheritance.*;
import course.oop.inheritance.media.Speaker;
import course.oop.inheritance.media.VideoBeam;

import java.time.LocalDateTime;
import java.util.ArrayList;

public class Program {

    public static void main(String[] args) {
        //Al descomentar la siguiente línea, habrá un error de compilación. No se pueden crear objetos de clases abstractas.
        //Space newSpace = new Space("Sala de juntas", 30);

        //HotDesk es una clase final. No se puede heredar, pero sí instanciar.

        HotDesk single = new HotDesk("Puesto 5");
        //A pesar de que el método getName fue definido en la clase base (Space), se puede acceder sin ningún problema.
        System.out.println("Nombre del puesto:  " + single.getName());

        //Cualquier objeto de una clase que implemente Schedulable se puede añadir a la lista.
        ArrayList<Schedulable> list = new ArrayList<>();
        list.add(new MeetingRoom("Sala creativa", 6));
        list.add(new Auditorium("Auditorio Múltiple", 30));
        list.add(new Speaker(500, true));
        list.add(new VideoBeam("SVGA"));

        LocalDateTime start = LocalDateTime.now();
        LocalDateTime end = start.plusDays(1);

        for(Schedulable item: list) {
            String className = item.getClass().getSimpleName();
            boolean isAvailable = item.isAvailable(start, end);
            System.out.println(className + " is available: " + isAvailable);
        }


    }
}

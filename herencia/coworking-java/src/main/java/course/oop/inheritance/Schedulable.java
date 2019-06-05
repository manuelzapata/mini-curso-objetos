package course.oop.inheritance;

import java.time.LocalDateTime;

/*
* Esta es una interfaz, no una clase. No se pueden crear objetos a partir de esta.
*
* Sirven para definir comportamientos que tendrán las clases.
*
* Es una alternativa a tener herencia múltiple.
*
* **/
public interface Schedulable {

    /*
    * Este método debe ser definido por todas las clases que implementen la interfaz.
    * */
    boolean isAvailable(LocalDateTime start, LocalDateTime end);

}

package course.oop.inheritance.media;

import course.oop.inheritance.Schedulable;

import java.time.LocalDateTime;

public class Speaker implements Schedulable {

    private double weight;
    private boolean isBluetooth;

    public Speaker(double weight, boolean isBluetooth) {
        this.weight = weight;
        this.isBluetooth = isBluetooth;
    }

    public boolean isAvailable(LocalDateTime start, LocalDateTime end) {
        //Implementar lógica para definir disponibilidad.
        return true;
    }

    public double getWeight() {
        return weight;
    }

    public void setWeight(double weight) {
        this.weight = weight;
    }

    public boolean isBluetooth() {
        return isBluetooth;
    }

    public void setBluetooth(boolean bluetooth) {
        isBluetooth = bluetooth;
    }


}

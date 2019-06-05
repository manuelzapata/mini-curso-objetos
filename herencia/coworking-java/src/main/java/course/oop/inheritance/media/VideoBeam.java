package course.oop.inheritance.media;

import course.oop.inheritance.Schedulable;

import java.time.LocalDateTime;

public class VideoBeam implements Schedulable {

    private String resolution;

    public VideoBeam(String resolution) {
        this.resolution = resolution;
    }

    public boolean isAvailable(LocalDateTime start, LocalDateTime end) {
        //Implementar lógica para definir disponibilidad.
        return true;
    }

    public String getResolution() {
        return resolution;
    }

    public void setResolution(String resolution) {
        this.resolution = resolution;
    }


}

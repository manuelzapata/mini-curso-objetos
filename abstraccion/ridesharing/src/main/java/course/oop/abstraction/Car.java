package course.oop.abstraction;

public class Car {

    private String plate;
    private Driver driver;
    private String model;

    public Car(String plate, Driver driver, String model) {
        this.plate = plate;
        this.driver = driver;
        this.model = model;
    }

    public String getPlate() {
        return plate;
    }

    public void setPlate(String plate) {
        this.plate = plate;
    }

    public Driver getDriver() {
        return driver;
    }

    public void setDriver(Driver driver) {
        this.driver = driver;
    }

    public String getModel() {
        return model;
    }

    public void setModel(String model) {
        this.model = model;
    }
}

package course.oop.abstraction;

public class Car {

    private String model;

    private int airbagNumber;
    private boolean absBrakes;
    private boolean manualTransmition;

    private double maxSpeed;

    public Car() {

    }

    public String getModel() {
        return model;
    }

    public void setModel(String model) {
        this.model = model;
    }

    public int getAirbagNumber() {
        return airbagNumber;
    }

    public void setAirbagNumber(int airbagNumber) {
        this.airbagNumber = airbagNumber;
    }

    public boolean isAbsBrakes() {
        return absBrakes;
    }

    public void setAbsBrakes(boolean absBrakes) {
        this.absBrakes = absBrakes;
    }

    public boolean isManualTransmition() {
        return manualTransmition;
    }

    public void setManualTransmition(boolean manualTransmition) {
        this.manualTransmition = manualTransmition;
    }

    public double getMaxSpeed() {
        return maxSpeed;
    }

    public void setMaxSpeed(double maxSpeed) {
        this.maxSpeed = maxSpeed;
    }
}

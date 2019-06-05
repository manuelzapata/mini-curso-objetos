package course.oop.abstraction;

public class Driver {

    private String licenseId;

    private String firstName;

    private String lastName;

    public Driver(String licenseId, String firstName, String lastName) {
        this.licenseId = licenseId;
        this.firstName = firstName;
        this.lastName = lastName;
    }

    public String getLicenseId() {
        return licenseId;
    }

    public void setLicenseId(String licenseId) {
        this.licenseId = licenseId;
    }

    public String getFirstName() {
        return firstName;
    }

    public void setFirstName(String firstName) {
        this.firstName = firstName;
    }

    public String getLastName() {
        return lastName;
    }

    public void setLastName(String lastName) {
        this.lastName = lastName;
    }
}

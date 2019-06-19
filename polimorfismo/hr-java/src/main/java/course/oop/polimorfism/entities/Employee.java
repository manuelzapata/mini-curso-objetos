package course.oop.polimorfism.entities;

import java.time.Duration;
import java.time.LocalDate;

public class Employee {

    private int employeeID;
    private String firstName;
    private String lastName;
    private LocalDate startDate;
    private double baseSalary;

    public Employee(int employeeID, String firstName, String lastName, LocalDate startDate, double baseSalary) {
        this.employeeID = employeeID;
        this.firstName = firstName;
        this.lastName = lastName;
        this.startDate = startDate;
        this.baseSalary = baseSalary;
    }

    public int calculateWorkingDays(LocalDate endDate) {
        System.out.println("Método con parámetros");

        int days = (int)Duration.between(startDate.atStartOfDay(), endDate.atStartOfDay()).toDays();
        return days;
    }

    public int calculateWorkingDays() {
        System.out.println("Método sin parámetros");
        int result = calculateWorkingDays(LocalDate.now());
        return result;
    }

    public double calculateNetSalary() {

        System.out.println("Estamos en la clase Employee");

        final double socialSecurity = 0.08;

        double netSalary = baseSalary * (1 - socialSecurity);
        return netSalary;

    }
}

package course.oop.polimorfism.entities;

import java.time.LocalDate;

public class Manager extends Employee {

    private double bonus;

    public Manager(int employeeID, String firstName, String lastName, LocalDate startDate, double baseSalary, double bonus) {
        super(employeeID, firstName, lastName, startDate, baseSalary);
        this.bonus = bonus;
    }

    public double CalculateNetSalary()
    {
        System.out.println("Estamos en la clase Manager");
        double baseSalary = super.CalculateNetSalary();
        baseSalary += bonus;
        return baseSalary;
    }
}

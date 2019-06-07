package course.oop.polimorfism;

import course.oop.polimorfism.entities.Employee;
import course.oop.polimorfism.entities.Manager;

import java.time.LocalDate;

public class Program {

    public static void main(String[] args) {

        Employee employeeOne = new Employee(1,
                "Juan",  "De Las Nieves",
                LocalDate.of(2019, 1, 1),
                100);

        Manager managerOne = new Manager (2,
                "Lord", "Commander",
                LocalDate.of(2008, 1, 1),
                10000, 1000);

        Employee employeeTwo = managerOne;

        //Polimorfismo por sobreescritura

        System.out.println("Salario employeeOne: " + employeeOne.CalculateNetSalary());
        System.out.println();

        System.out.println("Salario employeeTwo: " + employeeTwo.CalculateNetSalary());
        System.out.println();

        System.out.println("Salario managerOne: " + managerOne.CalculateNetSalary());
        System.out.println();

        //Polimorfismo por sobrecarga

        managerOne.CalculateVacationDays();

        managerOne.CalculateVacationDays(LocalDate.of(2019, 1, 1));

    }

}

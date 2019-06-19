package course.oop.polimorfism;

import course.oop.polimorfism.entities.Employee;
import course.oop.polimorfism.entities.Manager;

import java.time.LocalDate;

public class Program {

    public static void main(String[] args) {

        Manager managerOne = new Manager (2,
                "Lord", "Commander",
                LocalDate.of(2008, 1, 1),
                10000, 1000);

        //Polimorfismo por sobrecarga

        managerOne.calculateWorkingDays();

        managerOne.calculateWorkingDays(LocalDate.of(2019, 1, 1));
        System.out.println();

        Employee employeeOne = new Employee(1,
                "Juan",  "De Las Nieves",
                LocalDate.of(2019, 1, 1),
                100);

        //El mismo objeto managerOne, pero accedido como tipo Employee.
        Employee employeeTwo = managerOne;

        //Polimorfismo por sobreescritura

        System.out.println("Salario employeeOne: " + employeeOne.calculateNetSalary());
        System.out.println();

        System.out.println("Salario employeeTwo: " + employeeTwo.calculateNetSalary());
        System.out.println();

        System.out.println("Salario managerOne: " + managerOne.calculateNetSalary());
        System.out.println();


    }

}

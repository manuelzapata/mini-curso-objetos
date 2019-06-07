using Course.OOP.Polimorfism.HR.Entities;
using System;

namespace Course.OOP.Polimorfism.HR
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employeeOne = new Employee {
                EmployeeID = 1,
                FirstName = "Juan",
                LastName = "De Las Nieves",
                BaseSalary = 1000,
                StartDate = new DateTime(2019, 01, 01)
            };

            Manager managerOne = new Manager {
                EmployeeID = 2,
                FirstName = "Lord",
                LastName = "Commander",
                BaseSalary = 10000,
                Bonus = 1000,
                StartDate = new DateTime(2008, 01, 01)
            };

            Employee employeeTwo = (Employee)managerOne;

            //Polimorfismo por sobreescritura

            Console.WriteLine("Salario employeeOne: " + employeeOne.CalculateNetSalary());
            Console.WriteLine();

            Console.WriteLine("Salario employeeTwo: " + employeeTwo.CalculateNetSalary());
            Console.WriteLine();

            Console.WriteLine("Salario managerOne: " + managerOne.CalculateNetSalary());
            Console.WriteLine();

            //Polimorfismo por sobrecarga

            managerOne.CalculateVacationDays();

            managerOne.CalculateVacationDays(new DateTime(2019, 1, 1));
        }
    }
}

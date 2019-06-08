using System;
using System.Collections.Generic;
using System.Text;

namespace Course.OOP.Polimorfism.HR.Entities
{
    public class Employee
    {
        public int EmployeeID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime StartDate { get; set; }

        public double BaseSalary { get; set; }


        public int CalculateWorkingDays(DateTime endDate) {
            Console.WriteLine("Método con parámetros");
            int days = Math.Abs((endDate - StartDate).Days);
            return days;
        }

        public int CalculateWorkingDays() {
            Console.WriteLine("Método sin parámetros");
            int result = CalculateWorkingDays(DateTime.Now);
            return result;
        }

        public virtual double CalculateNetSalary() {

            Console.WriteLine("Estamos en la clase Employee");

            const double socialSecurity = 0.08;

            double netSalary = BaseSalary * (1 - socialSecurity);
            return netSalary;

        }


    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Course.OOP.Polimorfism.HR.Entities
{
    public class Manager : Employee
    {

        public double Bonus { get; set; }

        public double CalculateNetSalary()
        {

            Console.WriteLine("Estamos en la clase Manager");

            double baseSalary = base.CalculateNetSalary();
            baseSalary += Bonus;
            return baseSalary;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Course.OOP.Polimorfism.HR.Entities
{
    public class Manager : Employee
    {

        public double Bonus { get; set; }


        /*
         * Si se desea que el método utilizado sea el de la clase padre
         * cuando el tipo de variable sea Employee, entonces cambiar
         * el keyword de override a new.
         */
        public override double CalculateNetSalary()
        {

            Console.WriteLine("Estamos en la clase Manager");

            double baseSalary = base.CalculateNetSalary();
            baseSalary += Bonus;
            return baseSalary;
        }

    }
}

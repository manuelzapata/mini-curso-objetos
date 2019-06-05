using System;
using System.Collections.Generic;
using System.Text;

namespace Course.OOP.Inheritance.Business.Media
{
    public class Speaker: ISchedulable
    {

        private double Weight { get; set; }
        private bool IsBluetooth { get; set; }

        public Speaker(double weight, bool isBluetooth)
        {
            this.Weight = weight;
            this.IsBluetooth = isBluetooth;
        }

        public bool IsAvailable(DateTime start, DateTime end)
        {
            //Implementar lógica para definir disponibilidad.
            return true;
        }

    }
}

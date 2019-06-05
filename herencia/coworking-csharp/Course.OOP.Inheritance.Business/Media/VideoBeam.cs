using System;
using System.Collections.Generic;
using System.Text;

namespace Course.OOP.Inheritance.Business.Media
{
    public class VideoBeam : ISchedulable
    {

        public string Resolution { get; set; }

        public VideoBeam(String resolution)
        {
            this.Resolution = resolution;
        }

        public bool IsAvailable(DateTime start, DateTime end)
        {
            //Implementar lógica para definir disponibilidad.
            return true;
        }
    }
}

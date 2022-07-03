using System;
using System.Collections.Generic;
using System.Text;

namespace Ex.ParcAuto_Laborator9_
{
    class Camion : Autoutilitara
    {
        /// <summary>
        /// Creaza camion.
        /// </summary>
        /// <param name="producator"></param>
        /// <param name="model"></param>
        /// <param name="motor"></param>
        public Camion(string producator, string model, Diesel motor) : base(producator, model, motor)
        {
            motor = new Diesel();
            capacitateMaxima = 40;
        }
        public override string ToString()
        {
            return base.ToString() + $"Capacitate maxima materiale de constructii {capacitateMaxima} t\n";
        }
    }
}

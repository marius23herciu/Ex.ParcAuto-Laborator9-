using System;
using System.Collections.Generic;
using System.Text;

namespace Ex.ParcAuto_Laborator9_
{
    class Cisterna : Autoutilitara
    {
        /// <summary>
        /// Creaza cisterna.
        /// </summary>
        /// <param name="producator"></param>
        /// <param name="model"></param>
        /// <param name="motor"></param>
        public Cisterna(string producator, string model, Diesel motor) : base(producator, model, motor)
        {
            motor = new Diesel();
            capacitateMaxima = 10000;
        }
        public override string ToString()
        {
            return base.ToString() + $"Capacitate maxima a cisternei: {capacitateMaxima} mc\n";
        }
    }
}

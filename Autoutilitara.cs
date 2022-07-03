using System;
using System.Collections.Generic;
using System.Text;

namespace Ex.ParcAuto_Laborator9_
{
    abstract class Autoutilitara : Autovehicul
    {
        /*Autoutilitarele
• vor avea doar motoare diesel
• vor putea transporta combustibil si materiale de constructie
• vor avea capacitati maxime prestabilite
o 10000 mc pentru combustibil pentru cisterne
o 40t pentru camioane
• vor avea o metoda de incarcaMarfa care va incarca o cantitate primita ca parametru asigurand
incarcarea sub capacitatea maxima
*/
        public int capacitateMaxima;
        public double cantitateIncarcata;
        /// <summary>
        /// Creaza autoutilitara.
        /// </summary>
        /// <param name="producator"></param>
        /// <param name="model"></param>
        /// <param name="motor"></param>
        public Autoutilitara(string producator, string model, Diesel motor) : base(producator, model, motor)
        {

        }
        /// <summary>
        /// Incarca marfa in autoutilitara.
        /// </summary>
        /// <param name="cantitate"></param>
        public void IncarcareMarfa(double cantitate)
        {
            if (this.cantitateIncarcata + cantitate <= capacitateMaxima)
            {
                this.cantitateIncarcata += cantitate;
            }
            else
            {
                Console.WriteLine("Cantitatea introdusa depaseste capacitatea maxima.");
            }
        }
        public override string ToString()
        {
            return base.ToString() + $"Cantitate incarcata {cantitateIncarcata}\n";
        }
    }
}

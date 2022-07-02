using System;
using System.Collections.Generic;
using System.Text;

namespace Ex.ParcAuto_Laborator9_
{
    class Autoutilitara : Autovehicul
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

        private double combustibilIncarcat;
        public const int maximCombustibil = 10000;
        private double materialeConstructiiToneIncarcate;
        public const int maxMaterialeConstructii = 40;
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
        /// Adauga combustibil daca incarcarea cu materiale de constructii este 0.
        /// </summary>
        /// <param name="combustibil"></param>
        public void IncarcareCombustibil(double combustibil)
        {
            if (materialeConstructiiToneIncarcate > 0)
            {
                Console.WriteLine("Autoutilitara contine materiale de constructii. Puteti incarca combustibil dupa ce acestea vor fi descarcate.");
            }
            else if (this.combustibilIncarcat + combustibil <= maximCombustibil)
            {
                this.combustibilIncarcat += combustibil;
            }
            else
            {
                Console.WriteLine("Combustibilul introdus depaseste capacitatea maxima.");
            }
        }
        /// <summary>
        ///  Adauga materiale de constructii daca cisterna de combustibil este 0.
        /// </summary>
        /// <param name="materialeConstructii"></param>
        public void IncarcareMaterialeConstructii(double materialeConstructii)
        {
            if (combustibilIncarcat > 0)
            {
                Console.WriteLine("Cisterna contine combustibil. Puteti incarca materialele dupa ce aceasta va fi golita.");
            }
            else if (this.materialeConstructiiToneIncarcate + materialeConstructii <= maxMaterialeConstructii)
            {
                this.materialeConstructiiToneIncarcate += materialeConstructii;
            }
            else
            {
                Console.WriteLine("Greutatea introdusa depaseste capacitatea maxima.");
            }
        }
        public override string ToString()
        {
            if (combustibilIncarcat == 0 && materialeConstructiiToneIncarcate != 0)
            {
                return base.ToString() + $"Tonaj materiale de constructii {materialeConstructiiToneIncarcate}";
            }
            if (materialeConstructiiToneIncarcate == 0 && combustibilIncarcat != 0)
            {
                return base.ToString() + $"Combustibil incarcat {combustibilIncarcat}\n";
            }
            return base.ToString() + $"Combustibil incarcat {combustibilIncarcat}\n" +
                $"Tonaj materiale de constructii {materialeConstructiiToneIncarcate}";
        }
    }
}

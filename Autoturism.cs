using System;
using System.Collections.Generic;
using System.Text;

namespace Ex.ParcAuto_Laborator9_
{
    class Autoturism : Autovehicul
    {
        /*Autoturismele
• vor avea un numar de locuri
• vor avea motoare electrice sau hibride
• la pornirea autoturismelor, dupa pornirea motorului, acestea vor inchide usile afisand acest
lucru pe ecran.
*/

        private int numarLocuri;
        private bool usiBlocate = false;
        /// <summary>
        /// Creaza autoturism electric.
        /// </summary>
        /// <param name="producator"></param>
        /// <param name="model"></param>
        /// <param name="motor"></param>
        /// <param name="numarLocuri"></param>
        public Autoturism(string producator, string model, Electric motor, int numarLocuri) : base(producator, model, motor)
        {
            this.numarLocuri = numarLocuri;
        }
        /// <summary>
        /// Creaza autoturism hibrid.
        /// </summary>
        /// <param name="producator"></param>
        /// <param name="model"></param>
        /// <param name="motor"></param>
        /// <param name="numarLocuri"></param>
        public Autoturism(string producator, string model, Hibrid motor, int numarLocuri) : base(producator, model, motor)
        {
            this.numarLocuri = numarLocuri;
        }
        /// <summary>
        /// Porneste auto.
        /// </summary>
        public override void Porneste()
        {
            base.Porneste();
            usiBlocate = true;
            Console.WriteLine("Portierele au fost blocate.");
        }
        public override string ToString()
        {

            return base.ToString() + $"Numar locuri {numarLocuri}\n";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Ex.ParcAuto_Laborator9_
{
    abstract class Motor
    {
        /*Motoarele
• La pornirea acestora vor emite un zgomot caracteristic, afisandu-l ca mesaj in consola*/

        private bool pornit = false;
        public virtual void Porneste()
        {
            pornit = true;
        }
    }
    class Diesel : Motor
    {
        /// <summary>
        /// porneste motor diesel.
        /// </summary>
        public override void Porneste()
        {
            base.Porneste();
            Console.WriteLine("vrumvrum");
        }
        public override string ToString()
        {
            return "Diesel";
        }
    }
    class Electric : Motor
    {
        /// <summary>
        /// porneste motor electric.
        /// </summary>
        public override void Porneste()
        {
            base.Porneste();
            Console.WriteLine("zzzzzzzz");
        }
        public override string ToString()
        {
            return "Electric";
        }
    }
    class Hibrid : Diesel
    {
        /// <summary>
        /// porneste motor Hibrid.
        /// </summary>
        public override void Porneste()
        {
            base.Porneste();
            Console.WriteLine("zzzzzz");
        }
        public override string ToString()
        {
            return "Hibrid";
        }
    }
}

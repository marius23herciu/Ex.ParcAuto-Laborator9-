using System;
using System.Collections.Generic;
using System.Text;

namespace Ex.ParcAuto_Laborator9_
{
    abstract class Autovehicul
    {
        /*Autovehiculele vor avea
• Producator si model
• motor electric, hibrid sau cu diesel
• o metoda Porneste la apelul careia autovehiculul va porni motorul.
*/

        private string producator;
        private string model;
        private Motor motor;
        /// <summary>
        /// Creare autovehicul.
        /// </summary>
        /// <param name="producator"></param>
        /// <param name="model"></param>
        /// <param name="motor"></param>
        public Autovehicul(string producator, string model, Motor motor)
        {
            this.producator = producator;
            this.model = model;
            this.motor = motor;
        }
        /// <summary>
        /// Potneste auto.
        /// </summary>
        public virtual void Porneste()
        {
            this.motor.Porneste();
        }
        public override string ToString()
        {
            return $"{producator} {model} {motor}\n";
        }
    }
}

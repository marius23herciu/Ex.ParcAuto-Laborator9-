using System;
using System.Collections.Generic;
using System.Text;

namespace Ex.ParcAuto_Laborator9_
{
    class ParcAuto
    {
        private List<Autovehicul> listaAutovehicule = new List<Autovehicul>();
        /// <summary>
        /// Adaugare auto in parcul auto.
        /// </summary>
        /// <param name="auto"></param>
        public void AdaugareAuto(Autovehicul auto)
        {
            listaAutovehicule.Add(auto);
        }
        /// <summary>
        /// porneste toate auto din parc.
        /// </summary>
        public void PornesteAuto()
        {
            foreach (Autovehicul auto in listaAutovehicule)
            {
                auto.Porneste();
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Autovehicul auto in listaAutovehicule)
            {
                sb.Append(auto);
            }
            return sb.ToString();
        }
    }
}

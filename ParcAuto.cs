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
        /// <summary>
        /// Opreste toate auto din parc.
        /// </summary>
        public void OpresteAuto()
        {
            foreach (Autovehicul auto in listaAutovehicule)
            {
                auto.Opreste();
            }
        }
        /// <summary>
        /// scoate tipul de auto introdus din lista parcului auto.
        /// </summary>
        /// <param name="auto"></param>
        public void ScoatereAutoDinStoc(Autovehicul auto)
        {
            for (int i = 0; i < listaAutovehicule.Count; i++)
            {
                if (listaAutovehicule[i].Equals(auto))
                {
                    listaAutovehicule.Remove(listaAutovehicule[i]);
                    break;
                }
            }
        }
        /// <summary>
        /// Elimina auto din stoc dupa indexul introdus.
        /// </summary>
        /// <param name="index"></param>
        public void EliminareAutoDupaIndex(int index)
        {
            listaAutovehicule.RemoveAt(index);
        }
        /// <summary>
        /// Afiseaza o lista cu toate autoutilitarele din stoc.
        /// </summary>
        public void AfisareAutoutilitare()
        {
            for (int i = 0; i < listaAutovehicule.Count; i++)
            {
                if (listaAutovehicule[i] is Autoutilitara)
                {
                    Console.WriteLine($"{i + 1}) " + listaAutovehicule[i]);
                }
            }
        }

        /// <summary>
        /// Returneaza autovehicul din lista parcului auto.
        /// </summary>
        /// <param name="index"></param>
        public Autovehicul ReturnareAuto(int index)
        {
            return listaAutovehicule[index];
        }
        /// <summary>
        /// Afiseaza autovehiculele din stoc.
        /// </summary>
        public void AfisareListaAuto()
        {
            for (int i = 0; i < listaAutovehicule.Count; i++)
            {
                Console.WriteLine($"{i + 1}) " + listaAutovehicule[i]);
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

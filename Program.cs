using System;

namespace Ex.ParcAuto_Laborator9_
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Scrieti un program care va modela un parc auto.
            Toate autovehiculele vor avea o metoda care va produce un sir de caractere ce va descrie in detaliu
fiecare autovehicul in parte (producator, model, continut, etc...).
Apelati-o in Main, si afisati-i rezultatul pe ecran.
„Porniti” autovehiculele in metoda main
             */

            Autoutilitara utilitara = new Autoutilitara("Renault", "Mare", new Diesel());
            Autoturism electric = new Autoturism("Tesla", "12354", new Electric(), 5);
            Autoturism hibrid = new Autoturism("Dacia", "spring", new Hibrid(), 4);
            
            utilitara.IncarcareMaterialeConstructii(50);
            utilitara.IncarcareMaterialeConstructii(20.5);
            utilitara.IncarcareCombustibil(100);

            ParcAuto parcAuto = new ParcAuto();
            parcAuto.AdaugareAuto(hibrid);
            parcAuto.AdaugareAuto(electric);
            parcAuto.AdaugareAuto(utilitara);

            Console.WriteLine(parcAuto);

            parcAuto.PornesteAuto();
        }
    }
}

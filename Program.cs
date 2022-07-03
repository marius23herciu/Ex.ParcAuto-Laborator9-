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


            Autoturism electric = new Autoturism("Tesla", "12354", new Electric(), 5);
            Autoturism hibrid = new Autoturism("Dacia", "spring", new Hibrid(), 4);
            Camion camion = new Camion("Man", "540", new Diesel());
            Cisterna cisterna = new Cisterna("Iveco", "IV100", new Diesel());

            camion.IncarcareMarfa(50);
            camion.IncarcareMarfa(20.5);

            ParcAuto parcAuto = new ParcAuto();

            parcAuto.AdaugareAuto(hibrid);
            parcAuto.AdaugareAuto(electric);
            parcAuto.AdaugareAuto(camion);
            parcAuto.AdaugareAuto(cisterna);

            Console.WriteLine(parcAuto);
            parcAuto.PornesteAuto();

            Camion testEliminareStoc = new Camion("Eliminare", "test", new Diesel());
            parcAuto.ScoatereAutoDinStoc(testEliminareStoc);
            Console.WriteLine(parcAuto);

            parcAuto.PornesteAuto();


            //////////////////    MENIU PARC AUTO    ///////////////////

            Console.WriteLine("Doriti sa faceti modificari in parcul auto?   y/n");
            char yesOrNo = Console.ReadKey().KeyChar;
            Console.WriteLine();
            while (yesOrNo == 'y')
            {
                Console.WriteLine("Doriti sa:\n" +
                "Adaugati autovehucul(1), Scoateti autovehicul din stoc(2) sau Incarcare autoutilitara(3)?\n" +
                    "Tastati numarul corespunzator operatiunii dorite:");
                int raspuns = int.Parse(Console.ReadLine());
                while (raspuns < 1 || raspuns > 3)
                {
                    Console.WriteLine("Input gresit!");
                    raspuns = int.Parse(Console.ReadLine());
                }
                switch (raspuns)
                {
                    case 1:
                        AdaugareAutovehicul(parcAuto);
                        break;
                    case 2:
                        EliminareAutoDinStoc(parcAuto);
                        break;
                    default:
                        IncarcareMarfa(parcAuto);
                        break;
                }
                Console.WriteLine("Doriti sa faceti modificari in parcul auto?  y/n");
                yesOrNo = Console.ReadKey().KeyChar;
                Console.WriteLine();
            }

            ///////////////////////////   STOP MENIU    ////////////////////////////////////////////


            Console.WriteLine(parcAuto);
            parcAuto.PornesteAuto();
            parcAuto.OpresteAuto();
        }

        public static Autoturism CreareElectric()
        {
            Console.WriteLine("Introduceti producatorul:");
            string producator = Console.ReadLine();
            Console.WriteLine("Introduceti modelul:");
            string model = Console.ReadLine();
            Console.WriteLine("Introduceti numarul de locuri:");
            int numarLocuri = int.Parse(Console.ReadLine());
            return new Autoturism(producator, model, new Electric(), numarLocuri);
        }
        public static Autoturism CreareHibrid()
        {
            Console.WriteLine("Introduceti producatorul:");
            string producator = Console.ReadLine();
            Console.WriteLine("Introduceti modelul:");
            string model = Console.ReadLine();
            Console.WriteLine("Introduceti numarul de locuri:");
            int numarLocuri = int.Parse(Console.ReadLine());
            return new Autoturism(producator, model, new Hibrid(), numarLocuri);
        }
        public static Cisterna CreareCisterna()
        {
            Console.WriteLine("Introduceti producatorul:");
            string producator = Console.ReadLine();
            Console.WriteLine("Introduceti modelul:");
            string model = Console.ReadLine();
            return new Cisterna(producator, model, new Diesel());
        }
        public static Camion CreareCamion()
        {
            Console.WriteLine("Introduceti producatorul:");
            string producator = Console.ReadLine();
            Console.WriteLine("Introduceti modelul:");
            string model = Console.ReadLine();
            return new Camion(producator, model, new Diesel());
        }
        public static void AdaugareAutovehicul(ParcAuto parcAuto)
        {
            Console.WriteLine("Adaugati Autoturism electric(1), Autoturism hibrid(2)\n" +
                            "Cisterna(3) sau Camion (4)?");
            int raspuns = int.Parse(Console.ReadLine());
            switch (raspuns)
            {
                case 1:
                    parcAuto.AdaugareAuto(CreareElectric());
                    break;
                case 2:
                    parcAuto.AdaugareAuto(CreareHibrid());
                    break;
                case 3:
                    parcAuto.AdaugareAuto(CreareCisterna());
                    break;
                default:
                    parcAuto.AdaugareAuto(CreareCamion());
                    break;
            }
        }
        public static void  EliminareAutoDinStoc(ParcAuto parcAuto)
        {
            Console.WriteLine("Lista autovehicule aflate in stoc:");
            parcAuto.AfisareListaAuto();
            Console.WriteLine("Introduceti numarl autovehicului pentru eliminare din stoc:");
            int raspuns = int.Parse(Console.ReadLine());
            parcAuto.EliminareAutoDupaIndex(raspuns - 1);
        }
        public static void IncarcareMarfa(ParcAuto parcAuto)
        {
            Console.WriteLine("Lista autoutilitare aflate in stoc:");
            parcAuto.AfisareAutoutilitare();
            Console.WriteLine("Introduceti numarl autoutilitarei pentru incarcare:");
            int raspuns = int.Parse(Console.ReadLine());
            Autovehicul autoIncarcare = parcAuto.ReturnareAuto(raspuns - 1);
            if (autoIncarcare is Camion)
            {
                parcAuto.EliminareAutoDupaIndex(raspuns - 1);
                Camion camionIncarcare = (Camion)autoIncarcare;
                Console.WriteLine("Introduceti cantitate in tone pentru incarcare:");
                double cantitate = double.Parse(Console.ReadLine());
                camionIncarcare.IncarcareMarfa(cantitate);
                parcAuto.AdaugareAuto(camionIncarcare);
            }
            if (autoIncarcare is Cisterna)
            {
                parcAuto.EliminareAutoDupaIndex(raspuns - 1);
                Cisterna cisternaIncarcare = (Cisterna)autoIncarcare;
                Console.WriteLine("Introduceti cantitate in mc pentru incarcare:");
                double cantitate = double.Parse(Console.ReadLine());
                cisternaIncarcare.IncarcareMarfa(cantitate);
                parcAuto.AdaugareAuto(cisternaIncarcare);
            }
        }
    }
}

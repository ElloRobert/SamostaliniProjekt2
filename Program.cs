using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamostalniZadatak2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dizajner dizajnerMarko = new Dizajner("Marko","Ivić");
            Console.WriteLine(dizajnerMarko.PunoIme);
            

            dizajnerMarko.PredstaviSe();
            dizajnerMarko.Pisanje();
            dizajnerMarko.IzradaMockUpa();

            Back_end_developer back_End_DeveloperMarija = new Back_end_developer("Marija","Ivić");
            Console.WriteLine("\n"+back_End_DeveloperMarija.PunoIme);

            back_End_DeveloperMarija.PredstaviSe();
            back_End_DeveloperMarija.Pisanje();
            back_End_DeveloperMarija.Programiranje("C#");

            Front_end_developer front_End_DeveloperIvan = new Front_end_developer("Ivan", "Horvat");
            Console.WriteLine("\n"+front_End_DeveloperIvan.PunoIme);

            front_End_DeveloperIvan.PredstaviSe();
            front_End_DeveloperIvan.Pisanje();
            front_End_DeveloperIvan.Programiranje("HTML", "CSS");

            Tester testerJosip = new Tester("Josip", "Jozić");
            Console.WriteLine("\n"+ testerJosip.PunoIme);

            testerJosip.PredstaviSe();
            testerJosip.Pisanje();
            testerJosip.Testiranje();
            testerJosip.PisanjeUputa();

            SCRUM_master scrum_masterPero = new SCRUM_master("Pero", "Perić");
            Console.WriteLine ("\n"+ scrum_masterPero.PunoIme);

            scrum_masterPero.PredstaviSe();
            scrum_masterPero.Pisanje();
            scrum_masterPero.UpravljanjeProjektom();
            Console.ReadLine();



        }
    }
}

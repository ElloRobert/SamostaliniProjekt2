using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamostalniZadatak2
{
    public class SCRUM_master : Voditelj
    {
        string ime { get; set; }
        string prezime { get; set; }
        public SCRUM_master(string aime, string aprezime)
        {
            this.ime = aime;
            this.prezime = aprezime;
        }

        public string PunoIme
        {
            get { return string.Format("{0} {1}", ime, prezime); }
        }
        public override void PredstaviSe()
        {
            Console.WriteLine($"Pozdrav moje ime je: {PunoIme}");
        }
        public override void Pisanje()
        {
            base.Pisanje();
            
        }
        protected override void Review1()
        {
            Console.WriteLine("Radim Review1 = Praćenje rada faze SPRINT1 i rješavanje problema");
        }

        protected override void Review2()
        {
            Console.WriteLine("Radim Review2 = Praćenje rada faze SPRINT2 i rješavanje problema");
        }

        protected override void Review3()
        {
            Console.WriteLine("Radim Review3 = Praćenje rada faze SPRINT3 i rješavanje problema");
        }

        protected override void Review4()
        {
            Console.WriteLine("Radim Review4 = Praćenje rada faze SPRINT4 i rješavanje problema");
        }

        protected override void PredajaAplikacije()
        {
            Console.WriteLine("Po završetku, predajem cijelu aplikaciju - uploadam zip datoteke cijele aplikacije");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamostalniZadatak2
{
    internal class Tester : ClanTima, ITester
    {
        string ime { get; set; }
        string prezime { get; set; }
        public Tester(string aime, string aprezime)
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

        
        public void PisanjeUputa()
        {
            Console.WriteLine("Izrađujem korisničke upute za aplikaciju"); 
        }

        public void Testiranje()
        {
            Console.WriteLine("Testiram aplikaciju");
        }
    }
}

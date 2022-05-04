using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamostalniZadatak2
{
    public class Dizajner : ClanTima, IDizajner
    {
        string ime { get; set; }
        string prezime { get; set; }
        public Dizajner(string aime, string aprezime)
        {
            this.ime = aime;
            this.prezime = aprezime;
        }

        public string PunoIme
        {
            get { return string.Format("{0} {1}", ime, prezime); }
        }

        public override void Pisanje()
        {
            base.Pisanje();
        }

        public override void PredstaviSe()
        {
            
            Console.WriteLine($"Pozdrav moje ime je: {PunoIme}");
        }

        public void IzradaMockUpa()
        {
            Console.WriteLine("Izrađujem MockUp za aplikaciju");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamostalniZadatak2
{
    public abstract class ClanTima : ISszLogger, IOsoba
    {
        string ime { get; set; }
        string prezime { get; set; }
        public ClanTima(string aime, string aprezime)
        {
            this.ime = aime;
            this.prezime = aprezime;
        }

        public string PunoIme
        {
            get { return string.Format("{0} {1}", ime, prezime); }
        }
        public void Pisanje()
        {
            Console.WriteLine("Pisem Specifikaciju programskih zahtjeva za aplikaciju");
        }

        public virtual void PredstaviSe()
        {
            Console.WriteLine($"Pozdrav moje ime je: {PunoIme}");
        }
        
    }
}

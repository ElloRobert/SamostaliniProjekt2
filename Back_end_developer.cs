using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamostalniZadatak2
{
    public class Back_end_developer: Programer
    {
        string ime { get; set; }
        string prezime { get; set; }
        public Back_end_developer(string aime, string aprezime)
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
        public override void Programiranje( string jezik1)
        {
            base.Programiranje(jezik1);
        }
    }
}

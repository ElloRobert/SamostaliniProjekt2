using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamostalniZadatak2
{
    public abstract class Programer: ISszLogger,IOsoba
    {
        public void Pisanje()
        {
            Console.WriteLine("Pisem Specifikaciju programskih zahtjeva za aplikaciju");
        }

        public virtual void PredstaviSe()
        {
            
        }

        public virtual void Programiranje(string jezik1)
        {
            Console.WriteLine($"Programiram koristeći računalna znanja i vještinu: {jezik1}" );
        }
        public virtual void Programiranje(string jezik1, string jezik2)
        {
            Console.WriteLine($"Programiram koristeći računalna znanja i vještine: {jezik1}, {jezik2}");
        }


    }
}

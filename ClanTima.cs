using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamostalniZadatak2
{
    public abstract class ClanTima : ISszLogger, IOsoba
    {
        public virtual void Pisanje()
        {
            Console.WriteLine("Pisem Specifikaciju programskih zahtjeva za aplikaciju");
        }

        public virtual void PredstaviSe()
        {
            
        }
    }
}

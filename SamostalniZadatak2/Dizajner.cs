using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamostalniZadatak2
{
    public class Dizajner : ClanTima, IDizajner
    {
        public Dizajner( string aime, string aprezime): base(aime,aprezime)
        {

        }

        public void IzradaMockUpa()
        {
            Console.WriteLine("Izrađujem MockUp za aplikaciju");
        }
    }
}

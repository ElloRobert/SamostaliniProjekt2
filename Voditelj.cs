using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamostalniZadatak2
{
    public abstract class Voditelj : ISszLogger, IOsoba
    {
        public virtual void Pisanje()
        {
            Console.WriteLine("Pisem Specifikaciju programskih zahtjeva za aplikaciju");
        }

        public virtual void PredstaviSe()
        {
           
        }

        public virtual void UpravljanjeProjektom()
        {
            Review1();
            Review2();
            Review3();
            Review4();
            PredajaAplikacije();
        }

        protected abstract void PredajaAplikacije();
      
        protected abstract void Review1();


        protected abstract void Review2();

        protected abstract void Review3();

        protected abstract void Review4();
        
    }

}

using System;
using System.Collections.Generic;
using System.Text;

namespace Kartojimas
{
    public class Kamuolys : Spalva
    {
        public Kamuolys(int dydis, int metimuSkaicius)
        {
            Dydis = dydis;
            MetimuSkaicius = metimuSkaicius;
        }

        public int Dydis { get; private set; }
        public int MetimuSkaicius { get; set; }

        public void Mesti()
        {
            MetimuSkaicius ++ ;
        }

        public void Susprogdinti()
        {
            Dydis++ ;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Kartojimas
{
    public abstract class Zaislas
    {
        protected Zaislas(int dydis, Spalva kamuolioSpalva, int metimuSkaicius)
        {
            Dydis = dydis;
            MetimuSkaicius = metimuSkaicius;
            KamuolioSpalva = kamuolioSpalva;
        }

        public int Dydis { get;  set; }
        public int MetimuSkaicius { get; private set; }

        public Spalva KamuolioSpalva { get; set; }

        public virtual void Susprogdinti()
        {
            Dydis = 0;
        }
        public abstract void Mesti();

    }
}

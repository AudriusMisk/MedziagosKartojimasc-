﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Kartojimas
{
    public class Kamuolys
    {
        public Kamuolys(int dydis, int metimuSkaicius, Spalva kamuolioSpalva)
        {
            Dydis = dydis;
            MetimuSkaicius = metimuSkaicius;
            KamuolioSpalva = kamuolioSpalva;
        }


        public int Dydis { get; private set; }
        public int MetimuSkaicius { get; private set; }

        public Spalva KamuolioSpalva { get; set; }

        public void Mesti()
        {
            MetimuSkaicius ++ ;
        }

        public void Susprogdinti()
        {
            Dydis = 0;
        }

    }
}

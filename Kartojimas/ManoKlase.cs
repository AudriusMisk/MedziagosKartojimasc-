using System;
using System.Collections.Generic;
using System.Text;

namespace Kartojimas
{
    public interface IManoInterface // Interface negali turetu jokios implementacijos, turi but tik signatura (ka mes turime aprasyti klaseje kuri paveldes interface)
    {
        int ManoKintamasis { get; set; }
    }
    public class ManoKlase: IManoInterface // public - pasiekiama is bet kur, internal - tik is sio projekto | abstract klase - nori buti paveldeta | sealed - nenori buti paveldeta
    {
        int a; //paprastas kintamasis (field)

        public int MyProperty { get; private set; }     //Propertis turi geterius ir seterius per kur jis yra konfiguruojamas,
                                                        //get - kvieciamas kai properitis nuskaitos, set - nuskaitomas kai i properti irasoma nauja reiksme

        public int ManoKintamasis { get; set; } // butina implementuoti si property nes paveldime interface
        private void IrasytiProperty(int a)
        {
            MyProperty = a;
        }
       
    }

    public class ManoKlase1 : ManoKlase, IManoInterface // paveldeti galima tik 1 klase c#, kadangi tevineje jau yra interface property vaikineje klaseje nebereikia jo aprasineti
    {
        public int MyProperty1 { get; set; }
    }
}

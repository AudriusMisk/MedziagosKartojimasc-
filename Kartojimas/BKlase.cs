using System;
using System.Collections.Generic;
using System.Text;

namespace Kartojimas
{
    public class BKlase: BaseClass, IZodisKitaip
    {
        public BKlase(string name) : base(name)
        {
        }

        public override int NameKodas(int name)
        {
            throw new NotImplementedException();
        }

        public override string NameMetodas()
        {
            throw new NotImplementedException();
        }

        public string ZodisBeBalsiu()
        {
            throw new NotImplementedException();
        }

        public string ZodisBePriebalsiu()
        {
            throw new NotImplementedException();
        }

        public string ZodisSuPakeistomisBalsemis(char a)
        {
            throw new NotImplementedException();
        }

        public string ZodisSuPakeistomisPriebalsemis(int b)
        {
            throw new NotImplementedException();
        }
    }
}

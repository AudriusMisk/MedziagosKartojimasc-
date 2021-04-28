using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kartojimas
{
    public class BKlase: BaseClass, IZodisKitaip
    {
        private readonly List<char> balses = "a,e,i,u,y,o".ToList();
        public BKlase(string name) : base(name)
        {
        }

        public override int NameKodas(int a)
        {
            int suma = 0;
            foreach (var raide in Name)
            {
                suma += (int)raide - a;
            }
            return suma;
        }

        public override string NameMetodas()
        {
            throw new NotImplementedException();
        }

        public string ZodisBeBalsiu()
        {
            return Name.Where(r => !balses.Contains(r)).ToString();            
        }

        public string ZodisBePriebalsiu()
        {
            return Name.Where(r => balses.Contains(r)).ToString();
        }

        public string ZodisSuPakeistomisBalsemis(char a)
        {
            return Name.Where(r => balses.Contains(r)).ToString();
        }

        public string ZodisSuPakeistomisPriebalsemis(int b)
        {
            throw new NotImplementedException();
        }
    }
}

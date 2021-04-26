using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kartojimas
{
    public class AKlase : BaseClass
    {
        public AKlase(string name) : base(name)
        {
        }
        public override string NameMetodas()
        {
            var sb = new StringBuilder();
            var balses = "a,e,i,u,y,o".ToList();
            foreach (var raide in Name)
            {
                var kodas = balses.Contains(raide) ? ((int)raide).ToString() : raide.ToString() ;
                sb.Append(kodas);
            }
            return sb.ToString();
        }
        public override int NameKodas(int a)
        {
            int suma = 0;
            foreach (var raide in Name)
            {
                suma += (int)raide * a;
            }
            return suma;
        }
    }

}

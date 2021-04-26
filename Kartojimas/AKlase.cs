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
            var balses = "a,e,i,u,y,o".ToList();
            foreach (var raide in Name)
            {
                if (balses.Contains(raide))
                { 
                    
                }

            }
            return Name;
        }
        public override int NameKodas(int kodas)
        {
            Console.WriteLine($"{Name.Length} {kodas}");
            return kodas;
        }
    }

}

using System;
using System.Collections.Generic;
using System.Text;

namespace Kartojimas
{
    public interface IZodisKitaip
    {
        string ZodisBeBalsiu();
        string ZodisBePriebalsiu();
        string ZodisSuPakeistomisBalsemis(char a);
        string ZodisSuPakeistomisPriebalsemis(int b);

    }
}

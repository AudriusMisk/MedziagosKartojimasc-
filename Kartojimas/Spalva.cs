using System;
using System.Collections.Generic;
using System.Text;

namespace Kartojimas
{
    public class Spalva
    {
        public Spalva(byte red, byte green, byte blue)
        {
            Red = red;
            Green = green;
            Blue = blue;
        }

        public Spalva()
        {
            Red = 255;
            Green = 255;
            Blue = 255;
        }

        public byte Red { get; set; }
        public byte Green { get; set; }
        public byte Blue { get; set; }

        public void SpalvosKodoKeitimas()
        { 
        
        }
        public void GrayscaleValue()
        {
            decimal average = (decimal)((Red + Green + Blue) / 3);
        }

    }
}

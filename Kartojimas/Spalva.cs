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
            SpalvosInfo = 255;
        }

        public byte SpalvosInfo { get; set; }
        public byte Red { get; set; }
        public byte Green { get; set; }
        public byte Blue { get; set; }

        public void SpalvosKodoKeitimas()
        { 
        
        }
        public void GrayscaleValue()
        { 
        
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pß3_1
{
    internal class Program
    {
        class Color
        {
            private int _red;
            private int _green;
            private int _blue;
            public int Red {
                get
                {
                    return _red;
                }
                set
                {
                    _red = NormalizeColorValue(value);
                }
            }
            public int Green
            {
                get
                {
                    return _green;
                }
                set
                {
                    _green = NormalizeColorValue(value);
                }
            }
            public int Blue
            {
                get
                {
                    return _blue;
                }
                set
                {
                    _blue = NormalizeColorValue(value);
                }
            }
            public Color()
            {

            }
            public Color(int red, int green, int blue)
            {
                Red = red;
                Green = green;
                Blue = blue;
            }
            public void DisplayColor()
            {
                Console.WriteLine($"{_red}, {_green}, {_blue}");
            }
            private int NormalizeColorValue(int colorValue)
            {
                if (colorValue > 255)
                {
                    return 255;
                }
                if (colorValue < 0)
                {
                    return 0;
                }
                return colorValue;
            }
        }
        static void Main(string[] args)
        {
            Color crimson = new Color(190, 38, 76);
            crimson.DisplayColor();
            Color gray = new Color();
            gray.Red = 180;
            gray.Green = 180;
            gray.Blue = 165;
            gray.DisplayColor();
            Console.ReadKey(true);
        }
    }
}
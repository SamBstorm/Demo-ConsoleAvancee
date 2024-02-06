using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_ConsoleAvancee
{
    internal struct ColorString
    {
        public string text { get; set; }

        public Dictionary<int, ConsoleColor> colors { get; set; }

        public void Writeline()
        {
            for (int i = 0; i < text.Length; i++) { 
                if(colors.ContainsKey(i))
                {
                    Console.ForegroundColor = colors[i];
                }
                Console.Write(text[i]);
            }
            Console.ResetColor();
            Console.WriteLine();
        }

        public void Writeline(int x, int y, int width)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (colors.ContainsKey(i))
                {
                    Console.ForegroundColor = colors[i];
                }
                Console.SetCursorPosition(x + (i % width), y + (i / width));
                Console.Write(text[i]);
            }
            Console.ResetColor();
            Console.WriteLine();
        }
    }
}

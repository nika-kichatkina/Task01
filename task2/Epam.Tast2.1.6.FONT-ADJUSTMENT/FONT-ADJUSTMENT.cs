using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Tast2.FONT_ADJUSTMENT
{
    class FONT_ADJUSTMENT
    {
        [Flags]
        public enum font
        {
            Bold = 1,
            Italic = 2,
            Underlined = 4,
            None = 0
        }

        static void Main(string[] args)
        {
            var font_now = font.None;
            int check = 0;

            for (; ; )
            {
                Console.WriteLine("Параметы надписи: " + font_now);
                Console.WriteLine("Введите:");
                Console.WriteLine("         " + 1 + ": Bold");
                Console.WriteLine("         " + 2 + ": Italic");
                Console.WriteLine("         " + 3 + ": Underlined");
                Console.WriteLine("         " + 4 + ": Exit");

                check = int.Parse(Console.ReadLine());

                if (check == 4) break;

                switch (check)
                {
                    case 1:
                        if (font_now.HasFlag(font.Bold))
                        {
                            font_now = font_now ^ font.Bold;
                        }
                        else
                        {
                            font_now = font_now | font.Bold;
                        }

                        break;

                    case 2:
                        if (font_now.HasFlag(font.Italic))
                        {
                            font_now = font_now ^ font.Italic;
                        }
                        else
                        {
                            font_now = font_now | font.Italic;
                        }

                        break;
                    case 3:
                        if (font_now.HasFlag(font.Underlined))
                        {
                            font_now = font_now ^ font.Underlined;
                        }
                        else
                        {
                            font_now = font_now | font.Underlined;
                        }

                        break;

                }
            }
            //Console.WriteLine("Параметы надписи: " + font_now);
        }
    }
}










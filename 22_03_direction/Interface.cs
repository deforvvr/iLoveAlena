using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_03_direction
{
    public class Interface
    {
        public static void Print(int x, int y, string s, ConsoleColor fg = ConsoleColor.Cyan)
        {
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = fg;
            Console.Write(s);
        }
        public static void WindowSize(int x, int y)
        {
            Console.SetWindowSize(x, y);
        }

        public static void MakeInterface()
        {
            WindowSize(80, 28);
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Clear();
            Print(0, 0, "╔");
            for (int i = 1; i < 79; i++)
            {
                Print(i, 0, "═");
                Print(i, 25, "═");
            }
            Print(79, 0, "╗");
            for (int i = 1; i < 25; i++)
            {
                Print(0, i, "║");
                Print(79, i, "║");
                Print(39, i, "║");
                Print(40, i, "║");


            }
            Print(0, 25, "╚");
            Print(79, 25, "╝");

            for (int i = 1; i < 23; i++)
            {
                Print(13, i, "│");
                Print(26, i, "│");
                Print(53, i, "│");
                Print(66, i, "│");
            }
            for (int i = 1; i < 79; i++)
            {
                Print(i, 23, "─");
            }
            
            Print(13, 23, "┴");
            Print(26, 23, "┴");
            Print(53, 23, "┴");
            Print(66, 23, "┴");
            Print(39, 23, "║");
            Print(40, 23, "║");
            Print(13, 0, "╤");
            Print(26, 0, "╤");
            Print(53, 0, "╤");
            Print(66, 0, "╤");
            Print(39, 0, "╗");
            Print(40, 0, "╔");
            Print(40, 25, "╚");
            Print(39, 25, "╝");   
            Print(0, 23, "╟");
            Print(40, 23, "╟");
            Print(79, 23, "╢");
            Print(39, 23, "╢");
            Print(5, 1, "Name");
            Print(18, 1, "Name");
            Print(31, 1, "Name");
            Print(45, 1, "Name");
            Print(58, 1, "Name");
            Print(71, 1, "Name");
            Print(0, 27, "1");
            Print(8, 27, "2");
            Print(16, 27, "3");
            Print(24, 27, "4");
            Print(32, 27, "5");
            Print(40, 27, "6");
            Print(48, 27, "7");
            Print(56, 27, "8");
            Print(64, 27, "9");
            Print(72, 27, "10");

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PacMan.BL;
using System.IO;
using PacMan.UI;

namespace PacMan.UI
{
    class PacmanUI
    {
        public static void remove(int X, int Y)
        {
            Console.SetCursorPosition(Y, X);
            Console.Write(" ");
        }
        public static void draw(int Y, int X)
        {
            Console.SetCursorPosition(Y, X);
            Console.Write("P");
        }
        public static void printNumber(int X)
        {
            Console.SetCursorPosition(115, 15);
            Console.Write(X);
        }
    }
}

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
    class GhostUI
    {
        public static void removeGhost(int X, int Y)
        {
            Console.SetCursorPosition(X, Y);
            Console.Write(" ");
        }
        public static void printGhost(char ghostCharacter)
        {
            Console.Write(ghostCharacter);
        }
        public static void printItem(int X, int Y, char ch)
        {
            Console.SetCursorPosition(Y, X);
            Console.Write(ch);
        }
    }
}

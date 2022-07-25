using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LineProb.DL;
using LineProb.BL;
namespace LineProb.UI
{
    class MyLineUI
    {
        public static MyLine makeALine()
        {
            Console.Write("Enter X cordinate of first point: ");
            int X1 = int.Parse(Console.ReadLine());
            Console.Write("Enter Y cordinate of first point: ");
            int Y1 = int.Parse(Console.ReadLine());
            MyPoint begin = new MyPoint(X1, Y1);

            Console.Write("Enter X cordinate of second point: ");
            int X2 = int.Parse(Console.ReadLine());
            Console.Write("Enter Y cordinate of second point: ");
            int Y2 = int.Parse(Console.ReadLine());
            MyPoint end = new MyPoint(X2, Y2);

            MyLine line = new MyLine(begin, end);
            return line;
        }
    }
}

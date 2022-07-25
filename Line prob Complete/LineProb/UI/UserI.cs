using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LineProb.DL;
using LineProb.BL;

namespace LineProb.UI
{
    class UserI
    {
        public static void clear()
        {
            Console.ReadKey();
            Console.Clear();
        }
        public static void printValue(double distance)
        {
            Console.WriteLine(distance);
        }
        public static string menu()
        {
            Console.WriteLine("1.Make a Line");
            Console.WriteLine("2.Update the begin point");
            Console.WriteLine("3.Update the end point");
            Console.WriteLine("4.Show the update begin Point");
            Console.WriteLine("5.Show the update end point");
            Console.WriteLine("6.Get the Length of the line");
            Console.WriteLine("7.Get the Gradient of the Line");
            Console.WriteLine("8.Find the distance of begin point from zero coordinates");
            Console.WriteLine("9.Find the distance of end point from zero coordinates");
            Console.WriteLine("10.Exit");
            Console.Write("Enter your option: ");
            string option = Console.ReadLine();
            Console.WriteLine();
            return option;
        }
       
        public static void showUpdate(MyPoint Point)
        {
            Console.WriteLine("( {0} , {1} )", Point.getX(), Point.getY());
        }
        public static void getValues(ref int x, ref int y)
        {
            Console.Write("Enter X...");
            x = int.Parse(Console.ReadLine());
            Console.Write("Enter Y...");
            y = int.Parse(Console.ReadLine());
        }
    }
}

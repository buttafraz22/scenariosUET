using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OceanNavigation.BL;
using OceanNavigation.DL;
namespace OceanNavigation.UI
{
    class UserI
    {
        public static void clear()
        {
            Console.ReadKey();
            Console.Clear();
        }
        
        public static string menu()
        {
            Console.WriteLine("1.Add Ship");
            Console.WriteLine("2.View Ship position");
            Console.WriteLine("3.View Ship serial Number");
            Console.WriteLine("4.Change ship Position");
            Console.WriteLine("5.Exit");
            Console.Write("Enter your option: ");
            string choice = Console.ReadLine();
            return choice;
        }
       
    }
}

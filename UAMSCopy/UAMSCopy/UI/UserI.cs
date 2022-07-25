using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAMSCopy.BL;
using UAMSCopy.DL;

namespace UAMSCopy.UI
{
    class UserI
    {

        public static string mainMenu()//returns the option entered by the user...
        {
            Console.WriteLine("1.Add Student.");
            Console.WriteLine("2.Add Degree Program.");
            Console.WriteLine("3.Generate Merit.");
            Console.WriteLine("4.View Registered Students.");
            Console.WriteLine("5.View Students of a specific degree program.");
            Console.WriteLine("6.Register Subjects of a specific Student.");
            Console.WriteLine("7.Calculate Fees of a Registered student.");
            Console.WriteLine("8.Add Subject.");
            Console.WriteLine("9.Exit");
            Console.Write("Select any option...");
            string choice = Console.ReadLine();
            return choice;
        }
        public static void clear()
        {
            Console.ReadKey();
            Console.Clear();
        }
        public static void getInfo(ref string name)
        {
            Console.WriteLine("Enter the degree which you want to know: ");
            name = Console.ReadLine();
        }
        public static void getInfoI(ref string name)
        {
            Console.WriteLine("Enter the name  for which you want to register: ");
            name = Console.ReadLine();
        }
        public static void header()
        {
            Console.WriteLine("**************");
            Console.WriteLine("***  UAMS  ***");
            Console.WriteLine("**************");
        }
    }
}

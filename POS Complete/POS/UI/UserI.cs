using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS.BL;
using POS.DL;
using POS;
namespace POS.UI
{
    class UserI
    {
        public static string customerMenu()
        {
            Console.WriteLine("1.View all the products");
            Console.WriteLine("2.Buy the products");
            Console.WriteLine("3.Generate invoice");
            Console.WriteLine("4.Exit");
            Console.Write("Enter your choice....");
            string option = Console.ReadLine();
            return option;
        }

        public static string initialMenu()
        {
            Console.WriteLine("1.Sign in");
            Console.WriteLine("2.Sign up");
            Console.WriteLine("3.Exit");
            Console.Write("Enter your option....");
            string option = (Console.ReadLine());
            return option;
        }


        public static string adminMenu()
        {
            Console.WriteLine("1.Add Product.");
            Console.WriteLine("2.View All Products.");
            Console.WriteLine("3.Find Product with Highest Unit Price.");
            Console.WriteLine("4.View Sales Tax of All Products.");
            Console.WriteLine("5.Products to be Ordered. (less than threshold)");
            Console.WriteLine("6.Exit");
            Console.Write("Enter your option...");
            string option = Console.ReadLine();
            return option;
        }
        public static void clear()
        {
            Console.ReadKey();
            Console.Clear();
        }

    }
}



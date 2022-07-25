using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeshaCoffee.BL;
using TeshaCoffee.DL;
using TeshaCoffee;

namespace TeshaCoffee.UI
{
    class UserI
    {
       public static string Menu()
       {
            Console.WriteLine("1.Add a Menu item");
            Console.WriteLine("2.View the Cheapest Item in the menu");
            Console.WriteLine("3.View the Drink’s Menu");
            Console.WriteLine("4.View the Food’s Menu");
            Console.WriteLine("5.Add Order");
            Console.WriteLine("6.Fulfill the Order");
            Console.WriteLine("7.View the Orders’s List");
            Console.WriteLine("8.Total Payable Amount");
            Console.WriteLine("9.Exit");
            Console.Write("Enter your object...");
            string choice = Console.ReadLine();
            return choice;
       }
        public static void displayData(float i)
        {
            Console.WriteLine(i);
        }
        public static void header(CoffeeShop c)
        {
            Console.WriteLine("Welcome to {0}", c.getName());
        }

        public static void clear()
        {
            Console.ReadKey();
            Console.Clear();
        }
    }
}

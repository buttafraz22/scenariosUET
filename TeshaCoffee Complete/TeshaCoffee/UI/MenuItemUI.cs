using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeshaCoffee.BL;
using TeshaCoffee.DL;
namespace TeshaCoffee.UI
{
    class MenuItemUI
    {
        public static void display(List<MenuItem> p)
        {
            // Console.WriteLine("n");
            foreach (MenuItem j in p)
            {
                Console.WriteLine("{0}                {1}       {2}", j.name, j.getPrice(), j.type);
            }
        }
        public static MenuItem getItem()
        {
            MenuItem refer = null;
            Console.WriteLine("Enter name: ");
            string name = Console.ReadLine();
            foreach (MenuItem i in CoffeeShopD.menu)
            {
                if (name == i.name)
                {
                    refer = i;
                    break;
                }
            }
            return refer;
        }
        public static void displayMenuItem(MenuItem p)
        {
            Console.WriteLine(p.name);
        }
        public static MenuItem getItemInfo()
        {
            Console.Write("Enter name of the item...");
            string name = Console.ReadLine();
            string type = "";
            do
            {
                Console.Write("Enter type(Food/Drink)...");
                type = Console.ReadLine();
            } while (type != "Food" && type != "Drink");
            Console.Write("Enter price of the item....");
            float price = float.Parse(Console.ReadLine());
            MenuItem obj = new MenuItem(name, type, price);
            return obj;
        }
    }
}

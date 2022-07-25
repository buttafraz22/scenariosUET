using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeshaCoffee.BL;
using System.IO;
namespace TeshaCoffee.DL
{
    class CoffeeShopD
    {
        public static List<MenuItem> menu = new List<MenuItem>();
        public static List<MenuItem> orders = new List<MenuItem>();
        public static void addMenuItem(MenuItem p)
        {
            menu.Add(p);
            //int x = menu.Count;
        }
        public static List<MenuItem> getListMenu()
        {
            return menu;
        }
        public static List<MenuItem> drinksMenu()
        {
            List<MenuItem> drink = new List<MenuItem>();
            foreach (MenuItem i in menu)
            {
                if (i.type == "drinks" || i.type == "drink" || i.type == "Drink")
                {
                    drink.Add(i);
                }
            }
            return drink;
        }
        public static List<MenuItem> foodMenu()
        {
            List<MenuItem> food = new List<MenuItem>();
            foreach (MenuItem i in menu)
            {
                if (i.type == "Food" || i.type == "food")
                {
                    food.Add(i);
                }
            }
            return food;
        }
        public static bool addOrder(MenuItem o)
        {
            orders.Add(o);
            return true;
        }
        public static void RemoveOrders()
        {
            orders.Clear();
        }
        public static MenuItem getCheapest()
        {
            List<MenuItem> test = CoffeeShopD.getListMenu();
            List<MenuItem> sort = test.OrderBy(o => o.getPrice()).ToList();
            return sort[0];
        }
        public static void writeMenuinFile()
        {
            StreamWriter file = new StreamWriter("dataCoffee.txt");
            {
                foreach (MenuItem meIt in CoffeeShopD.menu)
                {
                    file.WriteLine(meIt.name + "," + meIt.type + "," + meIt.getPrice());
                    file.Flush();
                }
                file.Close();
            }

        }
        public static void loadMenuItemfromFile()
        {
            StreamReader file = new StreamReader("dataCoffee.txt");
            string item = "";
            if(File.Exists("dataCoffee.txt"))
            {
                while((item = file.ReadLine()) != null)
                {
                    MenuItem m = new MenuItem();
                    string[] record = item.Split(',');
                    m.name = record[0];
                    m.type = record[1];
                    m.setPrice(float.Parse(record[2]));
                    menu.Add(m);
                }
                file.Close();
            }
        }
        public static void writeorderinFile()
        {
            StreamWriter file = new StreamWriter("dataOrders.txt");
            {
                foreach (MenuItem meIt in CoffeeShopD.orders)
                {
                    file.WriteLine(meIt.name + "," + meIt.type + "," + meIt.getPrice());
                    file.Flush();
                }
                file.Close();
            }

        }
        public static void loadOrderfromFile()
        {
            StreamReader file = new StreamReader("dataOrders.txt");
            string item = "";
            if (File.Exists("dataOrders.txt"))
            {
                while ((item = file.ReadLine()) != null)
                {
                    MenuItem o = new MenuItem();
                    string[] record = item.Split(',');
                    o.name = record[0];
                    o.type = record[1];
                    o.setPrice(float.Parse(record[2]));
                    orders.Add(o);
                }
                file.Close();
            }
        }
    }
    

}

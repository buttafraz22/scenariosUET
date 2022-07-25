using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeshaCoffee.DL;
using TeshaCoffee.BL;
namespace TeshaCoffee.UI
{
    class CoffeeShopUI
    {
        public static bool fulfillOrder()
        {
            if (CoffeeShopD.orders != null)
            {
                foreach (MenuItem i in CoffeeShopD.orders)
                {
                    Console.WriteLine("{0} has been fulfilled. ", i.name);
                    //Console.WriteLine("Fuck you");
                }
                CoffeeShopD.RemoveOrders();
            }
            else
                Console.WriteLine("All orders have been fulfill.");
            return true;
        }

    }
}

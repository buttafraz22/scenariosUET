using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS.BL;
using POS.DL;

namespace POS.UI
{
    class CustomerUI
    {
        public static void buyProduct(Customer cust)
        {
            Console.WriteLine("Enter name of the Product: ");
            string name = Console.ReadLine();
            Product order = ProductD.isProductExist(name);
            if (order != null)
            {
                cust.data.addBoughtProduct(order);
            }
            else
                Console.WriteLine("Sorry.");
        }
    }
}

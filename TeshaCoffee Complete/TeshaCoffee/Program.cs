using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeshaCoffee.BL;
using TeshaCoffee.DL;
using TeshaCoffee.UI;

namespace TeshaCoffee
{
    class Program
    {
        static void Main(string[] args)
        {
            CoffeeShop tcs = new CoffeeShop("Tesha's Coffee Shop");
            string option = "";
            CoffeeShopD.loadMenuItemfromFile();
            CoffeeShopD.loadOrderfromFile();
            do
            {
                UserI.header(tcs);
                option = UserI.Menu();
                if (option == "1")//add menu item
                {
                    MenuItem p = MenuItemUI.getItemInfo();
                    CoffeeShopD.addMenuItem(p);
                    CoffeeShopD.writeMenuinFile();
                    UserI.clear();
                }
                else if (option == "2")// view cheapest item in menu
                {
                    MenuItem p = CoffeeShopD.getCheapest();
                    MenuItemUI.displayMenuItem(p);
                    UserI.clear();
                }
                else if (option == "3")//view drink menu
                {
                    List<MenuItem> Drink = CoffeeShopD.drinksMenu();
                    MenuItemUI.display(Drink);
                    UserI.clear();
                }
                else if (option == "4")//view food menu
                {
                    List<MenuItem> Food = CoffeeShopD.foodMenu();
                    MenuItemUI.display(Food);
                    UserI.clear();
                }
                else if (option == "5")//Add Order
                {
                    MenuItemUI.display(CoffeeShopD.menu);
                    MenuItem order = MenuItemUI.getItem();
                    if (order != null)
                    {
                        CoffeeShopD.addOrder(order);
                        CoffeeShopD.writeorderinFile();
                    }
                    UserI.clear();
                }
                else if (option == "6")//fulfill the order
                {
                    CoffeeShopUI.fulfillOrder();
                    CoffeeShopD.writeorderinFile();
                    UserI.clear();
                }
                else if (option == "7")//view orders list
                {
                    MenuItemUI.display(CoffeeShopD.orders);
                    UserI.clear();
                }
                else if (option == "8")//total payable amount
                {
                    float totalPrice = tcs.getPayableAmount();
                    UserI.displayData(totalPrice);
                    UserI.clear();
                }
            } while (option != "9");
        }

    }
}

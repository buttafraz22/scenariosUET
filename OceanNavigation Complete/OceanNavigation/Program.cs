using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OceanNavigation.BL;
using OceanNavigation.DL;
using OceanNavigation.UI;
namespace OceanNavigation
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice = "";
            do
            {
                ShipD.loadShipFromFile();
                choice = UserI.menu();
                if (choice == "1")//add ship
                {
                    Ship ship = ShipUI.AddShip();
                    ShipD.addShip(ship);
                    ShipD.writeShipInFile();
                }
                else if (choice == "2")//view position
                {
                    ShipUI.printPos(); 
                }
                else if (choice == "3")//view serial number
                {
                    ShipUI.printSerial();
                }
                else if (choice == "4")//change position
                {
                    int count = 0;
                    Ship checkShip = ShipUI.getShipInfo(ref count);
                    ShipUI.changePos(checkShip);
                    ShipD.ships.RemoveAt(count);
                    ShipD.ships.Insert(count, checkShip);
                    ShipD.writeShipInFile();
                }
                UserI.clear();
            } while (choice != "5");

        }
    }
}

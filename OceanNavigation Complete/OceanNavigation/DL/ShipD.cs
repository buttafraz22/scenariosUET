using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OceanNavigation.BL;

namespace OceanNavigation.DL
{
    class ShipD
    {
        public static List<Ship> ships = new List<Ship>();
        public static void addShip(Ship ship)
        {
            ships.Add(ship);
        }
    }
}

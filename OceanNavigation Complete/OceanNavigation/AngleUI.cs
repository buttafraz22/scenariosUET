using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OceanNavigation.BL;
using OceanNavigation.DL;
namespace OceanNavigation
{
    class AngleUI
    {
        public static void printAngle(Angle i)
        {
            Console.Write("{0}{1} {2}{3} {4}", i.degrees, "\u00b0", i.minutes, "'", i.direction);
        }

        public static bool changeAngle(Angle i)
        {
            Console.Write("Enter new degree value...");
            i.degrees = int.Parse(Console.ReadLine());
            Console.Write("Enter new minutes value...");
            i.minutes = float.Parse(Console.ReadLine());
            Console.Write("Enter new Direction value...");
            i.direction = char.Parse(Console.ReadLine());
            return true;
        }
    }
}

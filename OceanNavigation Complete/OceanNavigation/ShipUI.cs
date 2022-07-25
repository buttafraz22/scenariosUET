using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OceanNavigation.BL;
using OceanNavigation.UI;
using OceanNavigation.DL;

namespace OceanNavigation
{
    class ShipUI
    {
        public static void printPos(Ship i)
        {
            Console.WriteLine("The Ship serial No is {0}", i.getSerial());
            Console.WriteLine("The ship Longitude is: ");
            AngleUI.printAngle(i.longitude);
            Console.WriteLine("The  ship latitude is: ");
            AngleUI.printAngle(i.latitude);
        }
        public static Ship AddShip()
        {
            Console.Write("Enter serial number......");
            string serialNo = Console.ReadLine();
            Console.WriteLine("Enter Longitude Position: ");
            int degrees = 0;
            do
            {
                Console.Write("Enter degrees...");
                degrees = int.Parse(Console.ReadLine());
            } while (degrees > 180 || degrees < 0);
            Console.Write("Enter minutes of the ship... ");
            float minutes = float.Parse(Console.ReadLine());
            char direction = ' ';
            do
            {
                Console.Write("Enter direction...");
                direction = char.Parse(Console.ReadLine());
            } while (direction != 'N' && direction != 'S');
            Angle longitude = new Angle(degrees, minutes, direction);

            Console.WriteLine("Enter Latitude Position: ");
            int degreesL = 0;
            do
            {
                Console.Write("Enter degrees...");
                degreesL = int.Parse(Console.ReadLine());
            } while (degreesL > 90 || degreesL < 0);
            Console.Write("Enter minutes of the ship... ");
            float minutesL = float.Parse(Console.ReadLine());
            char directionL = ' ';
            do
            {
                Console.Write("Enter direction...");
                directionL = char.Parse(Console.ReadLine());
            } while (directionL != 'E' && directionL != 'W');
            Angle latitude = new Angle(degreesL, minutesL, directionL);

            Ship ship = new Ship(serialNo, longitude, latitude);
            return ship;
        }
        public static bool changePos(Ship i)
        {
            Console.WriteLine("Enter Changed Longitude Position: ");
            do
            {
                Console.Write("Enter degrees...");
                i.longitude.degrees = int.Parse(Console.ReadLine());
            } while (i.longitude.degrees > 180 || i.longitude.degrees < 0);
            Console.Write("Enter minutes of the ship... ");
            i.longitude.minutes = float.Parse(Console.ReadLine());
            do
            {
                Console.Write("Enter direction...");
                i.longitude.direction = char.Parse(Console.ReadLine());
            } while (i.longitude.direction != 'N' && i.longitude.direction != 'S');

            Console.WriteLine("Enter Changed Latitude Position: ");
            do
            {
                Console.Write("Enter degrees...");
                i.latitude.degrees = int.Parse(Console.ReadLine());
            } while (i.latitude.degrees > 180 || i.latitude.degrees < 0);
            Console.Write("Enter minutes of the ship... ");
            i.latitude.minutes = float.Parse(Console.ReadLine());
            do
            {
                Console.Write("Enter direction...");
                i.latitude.direction = char.Parse(Console.ReadLine());
            } while (i.latitude.direction != 'E' && i.latitude.direction != 'W');
            return true;
        }
        public static Ship getShipInfo(ref int count)
        {
            Console.Write("Enter the ship Serial number whose position you want to change: ");
            string serialNo = Console.ReadLine(); ;
            Ship checkShip = new Ship(serialNo);
            foreach (Ship i in ShipD.ships)
            {
                if (serialNo == i.getSerial())
                {
                    checkShip = i;
                    break;
                }
                count++;
            }
            return checkShip;
        }
        public static void printPos()
        {
            foreach (Ship i in ShipD.ships)
            {
                Console.Write("Serial number {0} :", i.getSerial());
                AngleUI.printAngle(i.longitude);
                Console.Write(" & ");
                AngleUI.printAngle(i.latitude);
                Console.WriteLine();
            }
        }
        public static void printSerial()
        {
            foreach (Ship i in ShipD.ships)
            {
                Console.WriteLine(i.getSerial());
            }
        }
    }
}

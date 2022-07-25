using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OceanNavigation.BL;
using OceanNavigation.DL;
namespace OceanNavigation.UI
{
    class UserI
    {
        public static void changePos(Ship i)
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
        }
        public static Ship getShipInfo()
        {
            Console.Write("Enter the ship Serial number whose position you want to change: ");
            string serialNo = Console.ReadLine(); ;
            Ship checkShip = new Ship(serialNo);
            foreach (Ship i in ShipD.ships)
            {
                if (serialNo == i.serialNo)
                {
                    checkShip = i;
                    break;
                }
            }
            return checkShip;
        }
        public static void clear()
        {
            Console.ReadKey();
            Console.Clear();
        }
        public static void printPos()
        {
            foreach (Ship i in ShipD.ships)
            {
                Console.Write("Serial number {0} :", i.serialNo);
                i.longitude.printAngle();
                Console.Write(" & ");
                i.latitude.printAngle();
                Console.WriteLine();
            }
        }
        public static void printSerial()
        {
            foreach (Ship i in ShipD.ships)
            {
                Console.WriteLine(i.serialNo);
            }
        }
        public static string menu()
        {
            Console.WriteLine("1.Add Ship");
            Console.WriteLine("2.View Ship position");
            Console.WriteLine("3.View Ship serial Number");
            Console.WriteLine("4.Change ship Position");
            Console.WriteLine("5.Exit");
            Console.Write("Enter your option: ");
            string choice = Console.ReadLine();
            return choice;
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

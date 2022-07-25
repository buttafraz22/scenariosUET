using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OceanNavigation.BL;
using System.IO;

namespace OceanNavigation.DL
{
    class ShipD
    {
        public static List<Ship> ships = new List<Ship>();
        public static void addShip(Ship ship)
        {
            ships.Add(ship);
        }
        public static void writeShipInFile()
        {
            StreamWriter file = new StreamWriter("dataShip.txt");
            foreach(Ship s in ships)
            {
                file.WriteLine(s.getSerial()+","+s.longitude.degrees + ";" +s.longitude.minutes + ";" +s.longitude.direction + "," + s.latitude.degrees + ";" + s.latitude.minutes + ";" + s.latitude.direction);
                file.Flush();
            }
            file.Close();
        }
        public static void loadShipFromFile()
        {
            StreamReader file = new StreamReader("dataShip.txt");
            if(File.Exists("dataShip.txt"))
            {
                string item = "";
                while((item = file.ReadLine()) != null)
                {
                    string[] record = item.Split(',');
                    string serialNo = record[0];
                    string[] longitudeRec = record[1].Split(';');
                    string[] latitudeRec = record[2].Split(';');
                    Angle longitude = new Angle(int.Parse(longitudeRec[0]), float.Parse(longitudeRec[1]), char.Parse(longitudeRec[2]));
                    Angle latitude = new Angle(int.Parse(latitudeRec[0]), float.Parse(latitudeRec[1]), char.Parse(latitudeRec[2]));
                    Ship s = new Ship(serialNo, longitude, latitude);
                    ships.Add(s);
                }
                file.Close();
            }
        }
    }
}

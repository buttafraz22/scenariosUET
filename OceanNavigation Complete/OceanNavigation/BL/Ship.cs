using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OceanNavigation.DL;
namespace OceanNavigation.BL
{
    class Ship
    {
        private string serialNo;
        public Angle longitude;
        public Angle latitude;
        public string getSerial()
        {
            return serialNo;
        }
        public void setSerial(string serialNo)
        {
            this.serialNo = serialNo;
        }
        public Ship(string serialNo,Angle longitude,Angle latitude)
        {
            this.serialNo = serialNo;
            this.longitude = longitude;
            this.latitude = latitude;
        }
        
        public Ship (string serialNo)
        {
            this.serialNo = serialNo;
        }
        
    }
}

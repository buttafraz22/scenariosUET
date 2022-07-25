using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeshaCoffee.BL
{
    class MenuItem
    {
        public string name;
        public string type;
        private float price;
        public float getPrice()
        {
            return price;
        }
        public void setPrice(float price)
        {
            this.price = price;
        }
        public MenuItem()
        {
         
        }
        public MenuItem(string name,string type,float price)
        {
            this.name = name;
            this.type = type;
            this.price = price;
        }
    }
}

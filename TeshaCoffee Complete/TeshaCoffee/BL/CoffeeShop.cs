using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeshaCoffee.DL;
namespace TeshaCoffee.BL
{
    class CoffeeShop
    {
        private string name;
        public CoffeeShop(string name)
        {
            this.name = name;
        }
        public string getName()
        {
            return this.name;
        }
        public float getPayableAmount()
        {
            float isPay = 0.0f;
            foreach(var i in CoffeeShopD.orders)
            {
                isPay += i.getPrice();
            }
            return isPay;
        }
        
    }
}

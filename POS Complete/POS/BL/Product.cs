using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS.DL;
namespace POS.BL
{
    class Product
    {
        private string name;
        public string category;
        public float price;
        private int stock;
        private int minStock;

        public string getName()
        {
            return this.name;
        }
        public int getStock()
        {
            return this.stock;
        }
        public int getMinStock()
        {
            return this.minStock;
        }
        public void setStock(int stock)
        {
            this.stock = stock;
        }
        public void setMinStock(int minStock)
        {
            this.minStock = minStock;
        }
        public Product(string name, string category, float price, int stock, int minStock)
        {
            this.name = name;
            this.category = category;
            this.price = price;
            this.stock = stock;
            this.minStock = minStock;
        }
        public float SalesTax()
        {
            float tax1 = 0.0f;
            foreach (var i in ProductD.storeProducts)
            {
                if (i.category == "Fresh Fruit")
                {
                    float tax = i.price * 0.05F;
                    return tax;
                }
                else if (i.category == "Grocery")
                {
                    float tax = i.price * 0.10F;
                    return tax;
                }
                else
                {
                    float tax = i.price * 0.15F;
                    return tax;
                }
            }
            return tax1;
        }


    }
}

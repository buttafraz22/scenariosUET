using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS.BL;
using System.IO;
namespace POS.DL
{
    class ProductD
    {
        public static List<Product> storeProducts = new List<Product>();
        public static Product isProductExist(string name)
        {
            foreach (Product i in storeProducts)
            {
                if (name == i.getName())
                {
                    if (i.getStock() > 0)
                    {
                        i.setStock(i.getStock() - 1);
                        return i;
                    }
                }
            }
            return null;
        }
        
        public static Product highestProd()
        {

            List<Product> sorted = storeProducts.OrderByDescending(o => o.price).ToList();
            Product emp = sorted[0];
            return emp;
        }
        public static List<Product> isOrderProduct()
        {
            List<Product> getOrders = new List<Product>();
            foreach (var i in storeProducts)
            {
                if (i.getStock() < i.getMinStock())
                    getOrders.Add(i);
            }
            return getOrders;
        }

        public static void addProductsinList(Product p)
        {
            storeProducts.Add(p);
        }
        public static bool storeProductInFile()
        {
            StreamWriter file = new StreamWriter("dataProduct.txt");
            foreach(Product p in storeProducts)
            {
                file.WriteLine(p.getName()+","+p.category + "," +p.price + "," +p.getStock() + "," +p.getMinStock());
                file.Flush();
            }
            file.Close();
            return true;
        }
        public static void loadProductFromFile()
        {
            StreamReader file = new StreamReader("dataProduct.txt");
            if(File.Exists("dataProduct.txt"))
            {
                string item = "";
                while((item = file.ReadLine()) != null)
                {
                    string[] record = item.Split(',');
                    string name = record[0];
                    string category = record[1];
                    float price = float.Parse(record[2]);
                    int stock = int.Parse(record[3]);
                    int minStock = int.Parse(record[4]);
                    Product addPintoList = new Product(name, category, price, stock, minStock);
                    storeProducts.Add(addPintoList);
                }
                file.Close();
            }
        }
    }
}


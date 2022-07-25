using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS.BL;
using POS.DL;

namespace POS.UI
{
    class ProductUI
    {
        public static void viewProduct(List<Product> users)
        {
            Console.WriteLine("Name     Category      Price     Stock       Minimum Stock");
            foreach (Product i in users)
            {
                Console.WriteLine("{0}      {1}     {2}     {3}     {4}", i.getName(), i.category, i.price, i.getStock(), i.getMinStock());
            }
        }
        public static void viewCustomerProduct(List<Product> users)
        {
            Console.WriteLine("Name     Category      Price ");
            foreach (Product i in users)
            {
                Console.WriteLine("{0}      {1}     {2}", i.getName(), i.category, i.price);
            }
        }
        public static Product GetProductInfo()
        {
            Console.WriteLine("Add name of the product: ");
            string name = Console.ReadLine();

            Console.WriteLine("Add Category of the product: ");
            string category = Console.ReadLine();

            Console.WriteLine("Add price of the product: ");
            float price = float.Parse(Console.ReadLine());

            int stock, minStock;
            Console.WriteLine("Add stock of the product: ");
            stock = int.Parse(Console.ReadLine());

            Console.WriteLine("Add Threshold of the product: ");
            minStock = int.Parse(Console.ReadLine());
            Product obj = new Product(name, category, price, stock, minStock);
            return obj;
        }
        public static void SalesTax(List<Product> users)
        {
            foreach (var i in users)
            {
                if (i.category == "Fresh Fruit")
                {
                    float tax = i.price * 0.05F;
                    Console.WriteLine("Sales tax on {0} is {1}", i.getName(), tax);
                }
                else if (i.category == "Grocery")
                {
                    float tax = i.price * 0.10F;
                    Console.WriteLine("Sales tax on {0} is {1}", i.getName(), tax);
                }
                else
                {
                    float tax = i.price * 0.15F;
                    Console.WriteLine("Sales tax on {0} is {1}", i.getName(), tax);
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS.BL;
namespace POS.DL
{
    class CustomerD
    {
        public List<Product> orderP = new List<Product>();

        public float getTaxonProducts()
        {
            float tax = 0.0f;
            foreach(Product i in orderP)
            {
                tax += i.SalesTax();
            }
            return tax;
        }
        public void addBoughtProduct(Product p)
        {
            orderP.Add(p);
        }
        public float getBill()
        {
            float bill = 0.0f;
            foreach (Product i in orderP)
            {
                bill += i.price;
                bill += i.SalesTax();
            }
            return bill;
        }
    }
}

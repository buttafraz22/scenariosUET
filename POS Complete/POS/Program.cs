using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS.BL;
using POS.DL;
using POS.UI;
namespace POS
{
    class Program
    {
        static void Main(string[] args)
        {
            MUserD.LoadFromFile();
            string option = "";
            do
            {
                option = UserI.initialMenu();
                if (option == "1")
                {
                    UserI.clear();
                    MUser checkUser = MUser.getReference();
                    if (checkUser != null)
                    {
                        if (checkUser.isAdmin())
                        {
                            ProductD.loadProductFromFile();
                            string optionAd = "";
                            do
                            {
                                
                                UserI.clear();
                                optionAd = UserI.adminMenu();
                                if (optionAd == "1")//add product
                                {
                                    Product p = ProductUI.GetProductInfo();
                                    ProductD.addProductsinList(p);
                                    ProductD.storeProductInFile();
                                }
                                else if (optionAd == "2")//view product
                                {
                                    ProductUI.viewProduct(ProductD.storeProducts);
                                }
                                else if (optionAd == "3")
                                {
                                    Product highest = ProductD.highestProd();
                                    Console.WriteLine(highest.getName());
                                }
                                else if (optionAd == "4")
                                {
                                    ProductUI.SalesTax(ProductD.storeProducts);
                                }
                                else if (optionAd == "5")
                                {
                                    List<Product> getOrders = ProductD.isOrderProduct();
                                    ProductUI.viewProduct(getOrders);
                                }
                            } while (optionAd != "6");
                        }
                        else if (checkUser.isCustomer())
                        {
                            string customerOp = "";
                            Customer cust = new Customer("Test", "0000", "Test");
                            Customer cust1 = new Customer("Test1", "0000", "Test2");
                            do
                            {
                                ProductD.storeProducts.Clear();
                               ProductD.loadProductFromFile();
                                UserI.clear();
                                customerOp = UserI.customerMenu();
                                UserI.clear();
                                if (customerOp == "1")
                                {
                                    ProductUI.viewCustomerProduct(ProductD.storeProducts);
                                }
                                else if (customerOp == "2")
                                {
                                    ProductUI.viewCustomerProduct(ProductD.storeProducts);
                                    CustomerUI.buyProduct(cust);
                                }
                                else if (customerOp == "3")
                                {
                                    ProductUI.viewProduct(cust.data.orderP);
                                    float bill = cust.data.getBill();
                                    float tax = cust.data.getTaxonProducts();
                                    Console.WriteLine("Total bill is: " + bill + " having tax "+tax);
                                }
                            } while (customerOp != "4");
                        }
                    }
                }
                else if (option == "2")
                {
                    UserI.clear();
                    MUser obj = MUserUI.getInfo();
                    obj.setRole("CUSTOMER"); 
                    MUserD.User.Add(obj);
                    MUserD.writeInFile();
                }
            } while (option != "3");

        }
    }
}

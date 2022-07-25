using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1Self
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Lily's Age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Enter Washing Machine Price: ");
            int washPrice = int.Parse(Console.ReadLine());
            Console.Write("Enter Price of the toy: ");
            int toy = int.Parse(Console.ReadLine());

            bool checl = CheckPrice(age,washPrice,toy);
            if (checl)
            {
                Console.WriteLine("Yes");
            }
            else
                Console.WriteLine("No");

        }
        static bool CheckPrice(int age, int washPrice , int priceToys)
        {
            int toysCheck = ToyCalculator(age, priceToys);
            int moneyCheck = MoneyCount(age);
            int total = toysCheck + moneyCheck;
            if (total >= washPrice)
            {
                return true;
            }
            else
                return false;
            
        }
        static int ToyCalculator(int age, int price)
        {
            int toyCount = 0;
            for(int i = 1; i < age; ++i)
            {
                if (i % 2 == 0)
                    continue;
                else if (i == 1)
                    toyCount++;
                else
                    toyCount++;

            }
            int TotalPrice = toyCount * price;
            return TotalPrice;
        }
        static int MoneyCount(int age)
        {
            int money = 0;
            for (int i = 1; i < age; ++i)
            {
                if (i % 2 != 0)
                    continue;
                else if (i == 1)
                    continue;
                else
                    money += 10 * i;
            }
            
            return money;
        }
    }
}

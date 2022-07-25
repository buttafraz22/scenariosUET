using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SignInUp
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\BSCS\\second semester\\Object Oriented Programming\\Self Assessments\\SignInUp\\SignInUp.txt";
            string[] names = new string[10];
            string[] passwords = new string[10];
            int option = 8;
            do
            {

                Console.Clear();
                ReadData(path, names, passwords);
               /* for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(names[i]);
                }*/
                option = Menu();
                if (option == 1)//sign in
                {
                    Console.Write("Enter your name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter your password: ");
                    string password = Console.ReadLine();
                    Signin(name, password, names, passwords);
                }
                if (option == 2)//signup
                {
                    Console.Write("Enter your name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter your password: ");
                    string password = Console.ReadLine();
                    Signup(name, password, path);
                }
              string data =   Console.ReadLine();
            } while (option != 3);
        }

        static int Menu()
        {
            Console.WriteLine("1 . Sign in ");
            Console.WriteLine("2 . Sign up ");
            Console.WriteLine("Please Enter your Option:  ");
            int option = int.Parse(Console.ReadLine());
            return option;
        }
        static void Signin(string n, string p, string[] names, string[] passwords)
        {
            bool isFound = false;
            for (int i = 0; i < 10; i++)
            {
                if (n == names[i] && p == passwords[i])
                {
                    Console.WriteLine("Valid User ");
                    isFound = true;
                    Console.Write("v");
                }
            }
            if (isFound == false)
            {
                Console.WriteLine("Unauthorized Entry ");
            }
        }
        static string ParseData(string record, int field)
        {
            int commansCount = 1;
            string item = " ";
            for (int i = 0; i < record.Length; i++)
            {
                if (record[i] == ',')
                {
                    commansCount++;
                }
                if (commansCount == field)
                {
                    item = item + record[i];

                }
            }
            return item;
        }
        static void ReadData(string path, string[] names, string[] passwords)
        {
            int count = 0;
            if (File.Exists(path))
            {
                StreamReader fileVariable = new StreamReader(path);
                string record;
                while ((record = fileVariable.ReadLine()) != null)
                {
                    if (record == " " || record == "\0")
                        break;
                    names[count] = ParseData(record, 1);
                    passwords[count] = ParseData(record, 2);
                    count++;
                    
                    if (count >= 10)
                        break;
                }
                fileVariable.Close();
            }
        }
        static void Signup(string name, string password, string path)
        {
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(name + ',' + password);
            file.Flush();
            file.Close();
        }

    }
}

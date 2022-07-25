using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS.BL;
using System.IO;
namespace POS.DL
{
    class MUserD
    {
        public static List<MUser> User = new List<MUser>();
        public static void writeInFile()
        {

            string path = "dataUser.txt";
            StreamWriter file = new StreamWriter(path);
            foreach (MUser i in User)
            {
                file.WriteLine(i.getUsername() + "," + i.getPassword() + "," + i.getRole());
                file.Flush();
            }
            file.Close();

        }
        public static void LoadFromFile()
        {

            string path = "dataUser.txt";
            StreamReader file = new StreamReader(path);
            if (File.Exists(path))
            {
                string item = "";
                while ((item = file.ReadLine()) != null)
                {
                    string usernameA = MUser.parseData(item, 1);
                    string passwordA = MUser.parseData(item, 2);
                    string role = MUser.parseData(item, 3);
                    MUser obj = new MUser(usernameA, passwordA, role);
                    User.Add(obj);
                }
                file.Close();
            }
        }
    }
}

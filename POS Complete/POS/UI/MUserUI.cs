using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS.BL;
using POS.DL;

namespace POS.UI
{
    class MUserUI
    {
        public static MUser getInfo()
        {
            Console.WriteLine("Enter username: ");
            string username = Console.ReadLine();
            Console.WriteLine("Enter password: ");
            string password = Console.ReadLine();
            MUser obj = new MUser(username, password);
            return obj;
        }
    }
}

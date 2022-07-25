using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using POS.DL;
using POS.UI;
namespace POS.BL
{
    class MUser
    {
        public MUser(string username, string password, string role)
        {
            this.username = username;
            this.password = password;
            this.role = role;
        }
        public MUser(string username, string password)
        {
            this.username = username;
            this.password = password;
        }
        public MUser()
        {
            username = "";
            password = "";
            role = "";
        }
        private string username;
        private string password;
        private string role;
        
        public string getUsername()
        {
            return this.username;
        }
        public string getPassword()
        {
            return this.password;
        }
        public string getRole()
        {
            return this.role;
        }
        public void setPassword(string password)
        {
            this.password = password;
        }
        public void setUsername(string username)
        {
            this.username = username;
        }
        public void setRole(string role)
        {
            this.role = role;
        }
        public bool isAdmin()
        {
            if (role == "ADMIN")
                return true;
            return false;
        }
        public bool isCustomer()
        {
            if (role == "CUSTOMER")
                return true;
            return false;
        }
        public static MUser getReference()
        {
            MUser obj = MUserUI.getInfo();
            foreach (MUser i in MUserD.User)
            {
                if (obj.username == i.username && obj.password == i.password)
                {
                    obj = i;
                    
                    return obj;
                }
            }
            obj = null;
            return obj;
        }


        public static string parseData(string row, int column) // to parse comma separated file for loading file into relevant array
    {
        int commansCount = 1;
        string item = "";
        int index = 0;
        for (int i = 0; i < row.Length; i++)
        {

            /* if (ch == '\0')
                 return item;*/
            if (row[i] == ',')
            {
                commansCount++;
            }
            else if (commansCount == column)
            {
                item = item + row[i];
            }
            index++;
        }
         return item;
       }
    }
}

    


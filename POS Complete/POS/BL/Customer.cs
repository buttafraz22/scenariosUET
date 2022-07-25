using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS.DL;
namespace POS.BL
{
    class Customer
    {
        private string name;
        private string phoneNo;
        private string address;
        public CustomerD data;
        public Customer(string name,string phoneNo, string address)
        {
            this.name = name;
            this.phoneNo = phoneNo;
            this.address = address;
            this.data = new CustomerD();
        }
        
    }
}

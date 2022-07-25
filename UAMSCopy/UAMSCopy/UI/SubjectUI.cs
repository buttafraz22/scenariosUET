using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAMSCopy.BL;
using UAMSCopy.DL;

namespace UAMSCopy.UI
{
    class SubjectUI
    {
        public static Subject AddSubject()
        {
            Console.WriteLine("Add Subject name...");
            string type = Console.ReadLine();
            Console.WriteLine("Add Subject Code...");
            string code = Console.ReadLine();
            Console.WriteLine("Add credit hours...");
            int crH = int.Parse(Console.ReadLine());
            Console.WriteLine("Add Subject Fee...");
            int SubjectFee = int.Parse(Console.ReadLine());
            Subject s1 = new Subject(code, type, crH, SubjectFee);
            return s1;
        }
    }
}

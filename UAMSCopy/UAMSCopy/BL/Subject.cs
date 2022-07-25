using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using UAMSCopy.DL;

namespace UAMSCopy.BL
{
    class Subject
    {
       
        public string code;
        public string type;
        public int creditHours;
        public int SubjectFee;
        public Subject(string code, string type, int creditHours, int SubjectFee)
        {
            this.code = code;
            this.type = type;
            this.creditHours = creditHours;
            this.SubjectFee = SubjectFee;
        }

        public static Subject getSubject(string name)
        {
            Subject ret = null;
            foreach (Subject i in SubjectD.subject)
            {
                if (name == i.type)
                {
                    ret = i;
                    break;
                }
            }
            return ret;
        }
        public static bool isSubjectAlreadyExists(Subject name)
        {
            bool ret = false;
            foreach (Subject i in SubjectD.subject)
            {
                if (name.type == i.type && name.code == i.code)
                {
                    ret = true;
                    break;
                }
            }
            return ret;
        }
    }
}

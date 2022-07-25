using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAMSCopy.BL;
using UAMSCopy.DL;
using System.IO;

namespace UAMSCopy.DL
{
    class SubjectD
    {
        public static List<Subject> subject = new List<Subject>();
        public static bool LoadSubjectData()
        {
            string path = "DataSubject.txt";
            StreamReader file = new StreamReader(path);
            if (File.Exists(path))
            {
                string item = "";
                while ((item = file.ReadLine()) != null)
                {
                    string[] record = item.Split(',');
                    string type = record[0];
                    string code = record[1];
                    int creditHours = int.Parse(record[2]);
                    int Subjectfee = int.Parse(record[3]);
                    Subject s = new Subject(code, type, creditHours, Subjectfee);
                    subject.Add(s);
                }
                file.Close();

                return true;
            }
            else return false;
        }
        public static bool writeSubjectInFile()
        {
            StreamWriter file = new StreamWriter("DataSubject.txt");
            foreach (Subject s in subject)
            {
                file.WriteLine(s.type + "," + s.code + "," + s.creditHours + "," + s.SubjectFee);
                file.Flush();
            }
            file.Close();
            return true;
        }
    }
}

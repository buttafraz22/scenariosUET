using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAMSCopy.BL;
using System.IO;
namespace UAMSCopy.DL
{
    class studentD
    {
        public static List<student> Students = new List<student>();
        
        public static bool writeStudentInFile()
        {
            StreamWriter file = new StreamWriter("dataStudents.txt");
            foreach (student s in Students)
            {
                string prefName = "";   //registering preferences of the student
                for(int i = 0; i < s.selectedS.Count - 1; i++)
                {
                    prefName = prefName +  s.selectedS[i].getTitle() + ";" ; 
                }
                prefName = prefName + s.selectedS[s.selectedS.Count - 1].getTitle();

                file.WriteLine(s.getName()+","+s.getAge() + "," +s.getFSC() + "," +s.getEcat() + "," +prefName+","+"CS161");
                
                file.Flush();
            }
            file.Close();
            return true;
        }

        public static student isStudentAvailable(string name)
        {
            foreach (student s in Students)
            {
                if (s.getName() == name)
                {
                    return s;
                }
            }
            return null;
        }
        public static bool loadStudentFromFile()
        {
            string path = "dataStudents.txt";
            StreamReader file = new StreamReader(path);
            string item = "";
            if(File.Exists(path))
            {
                while((item = file.ReadLine()) != null)
                {
                    string[] record = item.Split(',');
                    string name = record[0];
                    int age = int.Parse(record[1]);
                    float FscM = float.Parse(record[2]);
                    float EcatM = float.Parse(record[3]);
                    student s = new student(name, age, FscM, EcatM);
                    
                    string [] splitForPref = record[4].Split(';');
                    foreach(string i in splitForPref)
                    {
                        DegreeProgram p = DegreeProgramD.GetProgram(i);
                        if( p != null)
                        {
                            s.selectedS.Add(p);
                        }
                    }
                    Students.Add(s);
                }
                file.Close();
                return true;
            }
            return false;
        }
    }
}

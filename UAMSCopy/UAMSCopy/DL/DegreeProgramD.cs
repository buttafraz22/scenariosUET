using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAMSCopy.BL;
using System.IO;
namespace UAMSCopy.DL
{
    class DegreeProgramD
    {

        public static List<DegreeProgram> programs = new List<DegreeProgram>();
        public static bool LoadFromFile()
        {
            string path = "dataPrograms.txt";
            StreamReader file = new StreamReader(path);
            if (File.Exists(path))
            {
                string item = "";
                while ((item = file.ReadLine()) != null)
                {
                    string[] record = item.Split(',');
                    string title = record[0];
                    string duration = record[1];
                    int CrH = int.Parse(record[2]);
                    int Seats = int.Parse(record[3]);
                    DegreeProgram m = new DegreeProgram(title, duration, CrH, Seats);

                    string[] subjectInFile = record[4].Split(';');
                    List<Subject> fileLoad = new List<Subject>();
                    foreach (string i in subjectInFile)
                    {
                        Subject s = Subject.getSubject(i);
                        if (s != null)
                        {
                            if (!Subject.isSubjectAlreadyExists(s))
                                fileLoad.Add(s);
                        }
                    }
                    m.parts = fileLoad;
                    if (!isProgramAlreadyExist(m))
                        programs.Add(m);
                }
                file.Close();
                return true;
            }
            else return false;
        }
        public static DegreeProgram GetProgram(string name)
        {
            DegreeProgram p = null;
            foreach(DegreeProgram i in programs)
            {
                if (name == i.getTitle())
                    p = i;
            }
            return p;
        }
        public static bool isProgramAlreadyExist(DegreeProgram name)
        {
            foreach (DegreeProgram i in DegreeProgramD.programs)
            {
                if (name.getTitle() == i.getTitle())
                    return true;
            }
            return false;
        }
        public static bool writeProgramInFile()
        {
            StreamWriter file = new StreamWriter("dataPrograms.txt");

            foreach (DegreeProgram i in programs)
            {
                string subjectName = "";
                foreach (Subject j in i.parts)
                {
                    subjectName = subjectName + (j.type + ";");
                }

                file.WriteLine(i.getTitle() + "," + i.duration + "," + i.getCrH() + "," + i.getSeats() + "," + subjectName);
                file.Flush();
            }
            file.Close();
            return true;
        }
    }
}

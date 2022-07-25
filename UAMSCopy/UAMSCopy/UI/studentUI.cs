using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAMSCopy.BL;
using UAMSCopy.DL;

namespace UAMSCopy.UI
{
    class studentUI
    {
        public static student AddStudent(List<DegreeProgram> programs)
        {
            Console.Write("Enter name of the student...");
            string name = Console.ReadLine();
            Console.Write("Enter the age of the student...");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Enter the FSC Marks of the student...");
            float FscMarks = float.Parse(Console.ReadLine());
            Console.Write("Enter ECAT Marks of the student...");
            float EcatMarks = float.Parse(Console.ReadLine());

            student s1 = new student(name, age, FscMarks, EcatMarks);
            Console.WriteLine("Available Programs...");
            foreach (DegreeProgram i in programs)
            {
                Console.WriteLine(i.getTitle());
            }
            Console.Write("How many preferences You want to enter...");
            int prefNo = int.Parse(Console.ReadLine());
            for (int i = 0; i <= prefNo; i++)
            {
                Console.WriteLine("Enter preference {0}", i + 1);
                string pref = Console.ReadLine();
                foreach (DegreeProgram j in programs)
                {
                    if (pref == j.getTitle())
                    {
                        s1.selectedS.Add(j);
                        break;
                    }

                }
            }
            return s1;
        }
        public static void RegisterSubject(List<Subject> subjects, student j)
        {
            Console.WriteLine("Enter Subject code...");
            string name = Console.ReadLine();
            bool checkSub = false;
            foreach (Subject i in subjects)
            {
                if (name == i.code)
                {
                    checkSub = true;
                    j.Subj.Add(i);
                    //Console.WriteLine(j.Subj[0].code);
                    //Console.WriteLine(studentD.Students[0].data.Subj[0].code);
                   // Console.ReadKey();
                }
            }
            if (!checkSub)
            {
                Console.WriteLine("Entered Subject does not exist in the system, try again.");
            }
        }
        public static bool printStudentDegree(List<student> students, string name)
        {
            foreach (student i in studentD.Students)
            {
                if (i.isSelected)
                {
                    if (i.Degree == name)
                    {
                        Console.WriteLine(i.getName());
                    }
                }
            }
            return true;
        }
        public static bool checkFee(List<student> students)
        {

            foreach (student i in students)
            {
                int StFee = 0;
               
                foreach (Subject j in i.Subj)
                {
                   
                    StFee += j.SubjectFee;
                    
               }
               Console.WriteLine("Student {0} has fee totalling to {1}", i.getName(), StFee);
            }
            return true;
        }
        public static void printStudentInfo()
        {
            foreach (student i in studentD.Students)
            {
                Console.WriteLine("{0} {1} {2} {3} ", i.getName(), i.getAge(), i.getFSC(), i.getEcat());
            }
        }
    }
}

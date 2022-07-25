using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAMSCopy.BL;
using UAMSCopy.DL;

namespace UAMSCopy.UI
{
    class DegreeProgramUI
    {
        public static void MeritAdmit(List<student> student, List<DegreeProgram> programs)
        {
            foreach (student s in student)
            {
                float merit = s.meritCalculator();
                bool isAdmission = s.isAdmitted(programs, merit);
                //Console.WriteLine(s.Degree);
                if (isAdmission)
                {
                    Console.WriteLine("Student {0} has been selected in {1} ", s.getName(), s.Degree);
                }
                else if (!isAdmission)
                {
                    Console.WriteLine("Student {0} has not been selected ", s.getName());
                }
            }

        }




        public static DegreeProgram AddProgram(List<Subject> subject)
        {
            Console.WriteLine("Enter Program name...");
            string title = Console.ReadLine();

            Console.WriteLine("Enter credit hours of the Program...");
            int CrH = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Duration of the program...");
            string duration = Console.ReadLine();

            Console.WriteLine("Enter seats of the subject...");
            int Seats = int.Parse(Console.ReadLine());

            DegreeProgram p1 = new DegreeProgram(title, duration, CrH, Seats);

            Console.WriteLine("Please Set the merit criteria of the program...");
            float criteria = float.Parse(Console.ReadLine());
            p1.setCriteria(criteria);

            Console.Write("How many Subjects You want to enter...");
            int prefNo = int.Parse(Console.ReadLine());

            int creditSum = 0;
            bool flagCredit = false;
            for (int i = 1; i <= prefNo; i++)
            {
                Console.WriteLine("Enter the Subject code: ");
                string name = Console.ReadLine();
                foreach (Subject j in subject)
                {
                    if (name == j.code)
                    {
                        creditSum += j.creditHours;
                        if (creditSum > 20)
                        {
                            Console.WriteLine("Added Subject have exceeded the amount of total credits of the subject.No more Addition.");
                            flagCredit = true;
                            break;
                        }
                        p1.addSubjects(j);
                    }
                }
                if (flagCredit)
                    break;
            }
            return p1;
        }
    }
}

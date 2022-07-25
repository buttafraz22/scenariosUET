using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAMSCopy.BL;
using UAMSCopy.DL;
using UAMSCopy.UI;

namespace UAMSCopy
{ 
    class Program
    {
        public static void Main(string[] args)
        {
            SubjectD.LoadSubjectData();
            DegreeProgramD.LoadFromFile();


            studentD.loadStudentFromFile();
            
            string choice = "";

            do
            {

                UserI.header();
                choice = UserI.mainMenu();
                if (choice == "1")//Add Student
                {
                    student enrollS = studentUI.AddStudent(DegreeProgramD.programs);
                    studentD.Students.Add(enrollS);
                    studentD.writeStudentInFile();
                    //Console.WriteLine("Student Added Successfully.");
                    UserI.clear();
                }
                else if (choice == "2")//Add degree program
                {
                    DegreeProgram AddP = DegreeProgramUI.AddProgram(SubjectD.subject);
                    DegreeProgramD.programs.Add(AddP);
                    DegreeProgramD.writeProgramInFile();
                    UserI.clear();
                }
                else if (choice == "3")//Generate Merit
                {
                    DegreeProgramUI.MeritAdmit(studentD.Students, DegreeProgramD.programs);
                    UserI.clear();
                }
                else if (choice == "4")// view Registered students
                {
                    studentUI.printStudentInfo();
                    UserI.clear();
                }
                else if (choice == "5")//Students of a specific degree program
                {
                    string name = "";
                    UserI.getInfo(ref name);
                    studentUI.printStudentDegree(studentD.Students, name);
                    UserI.clear();
                }
                else if (choice == "6")// Register subjects of a specific student
                {

                    string name = " ";
                    UserI.getInfoI(ref name);
                    student s1 = studentD.isStudentAvailable(name);
                    //student s1 = new student(name);
                    //student.getReference(s1, name);
                    if (s1 != null)
                    {
                        studentUI.RegisterSubject(SubjectD.subject, s1);
                        
                    }
                    
                    UserI.clear();
                }
                else if (choice == "7")//Calculate fees of registered student
                {
                    studentUI.checkFee(studentD.Students);
                    UserI.clear();
                }
                else if (choice == "8")//Adds subject into the system
                {
                    Subject s1 = SubjectUI.AddSubject();
                    SubjectD.subject.Add(s1);
                    SubjectD.writeSubjectInFile();
                    //Console.WriteLine("Added Successfully.");
                    UserI.clear();
                }
                //studentD.writeStudentInFile();
            } while (choice != "9");

        }

    }
}

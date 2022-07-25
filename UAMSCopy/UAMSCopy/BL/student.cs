using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAMSCopy.DL;
namespace UAMSCopy.BL
{
    class student
    {

        private string name;
        private int age;
        private float FscMarks;
        private float EcatMarks;
        public List<DegreeProgram> selectedS;
        public List<Subject> Subj;
        public bool isSelected = false;
        public string Degree = null;

        public string getName()
        {
            return this.name;
        }
        public int getAge()
        {
            return age;
        }
        public float getFSC()
        {
            return FscMarks;
        }
        public float getEcat()
        {
            return EcatMarks;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public void setAge(int age)
        {
            this.age = age;
        }
        public void setFSC(float FscMarks)
        {
            this.FscMarks = FscMarks;
        }
        public void setEcat(float EcatMarks)
        {
            this.EcatMarks = EcatMarks;
        }
        public student(string name)
        {
            this.name = name;
        }
        public student(string name, int age, float FscMarks, float EcatMarks)
        {
            this.name = name;
            this.age = age;
            this.FscMarks = FscMarks;
            this.EcatMarks = EcatMarks;
            this.selectedS = new List<DegreeProgram>();
            this.Subj = new List<Subject>();
        }
        public bool isAdmitted(List<DegreeProgram> programs, float merit)
        {
            string selection = "";

            for (int i = 0; i <= selectedS.Count; i++)
            {
                foreach (DegreeProgram j in programs)
                {
                    if ((j.getSeats() > 0) && (merit >= j.getCriteria()) || (j.getTitle() == selectedS[i].getTitle()))
                    {
                        isSelected = true;
                        selection = j.getTitle();
                        j.setSeats(j.getSeats() - 1);
                        Degree = selection;
                        return true;
                    }
                }
            }

            return false;
        }

        public int getCreditHours()
        {
            int count = 0;
            foreach (Subject i in Subj)
            {
                count += i.creditHours;
            }
            return count;
        }
        public float meritCalculator()
        {
            float merit = ((((FscMarks) / 1100) * 0.70F) + ((EcatMarks / 400) * 0.30F));
            merit *= 100.0F;
            // Console.Write(merit);
            return merit;
        }
        public static student getReference(student s1, string name)
        {
            s1 = null ;
            
            foreach (student i in studentD.Students)
            {
                if (name == i.name)
                {
                    s1 = i;
                    break;
                }
            }
            return s1;
        }
    }
}

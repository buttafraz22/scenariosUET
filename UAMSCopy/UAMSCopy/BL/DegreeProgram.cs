using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAMSCopy.BL
{
    class DegreeProgram
    {

        private string title;
        public string duration;
        public List<Subject> parts;
        private int CrH;
        private int Seats;
        private float criteria;
        public string getTitle()
        {
            return this.title;
        }
        public int getCrH()
        {
            return this.CrH;
        }
        public void setCrH(int CrH)
        {
            this.CrH = CrH;
        }
        public int getSeats()
        {
            return this.Seats;
        }
        public void setSeats(int Seats)
        {
            this.Seats = Seats;
        }
        public float getCriteria()
        {
            return this.criteria;
        }
        public void setCriteria(float criteria)
        {
           this.criteria = criteria;
        }
        public void setTitle(string title)
        {
            this.title = title;
        }
        public DegreeProgram(string title, string duration, int CrH, int Seats)
        {
            this.title = title;
            this.duration = duration;
            parts = new List<Subject>();
            this.CrH = CrH;
            this.Seats = Seats;
            this.criteria = 80.0f;
        }
        public void addSubjects(Subject s1)
        {
            parts.Add(s1);
        }
    }
}

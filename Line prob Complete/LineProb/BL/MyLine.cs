using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LineProb.DL;
namespace LineProb.BL
{
    class MyLine
    {
       
        private MyPoint begin;
        private MyPoint end;

        public MyPoint getBegin()
        {
            return begin;
        }
        public MyPoint getEnd()
        {
            return end;
        }
        public void setBegin(MyPoint begin)
        {
            this.begin = begin;
        }
        public void setEnd(MyPoint end)
        {
            this.end = end;
        }
        public MyLine ()
        {
            this.begin = new MyPoint();
            this.end = new MyPoint();
        }
        public MyLine(MyPoint begin, MyPoint end)//parametrized constructor
        {
            this.begin = begin;
            this.end = end;
        }
        public double getLength()
        {
            double length = 0.0D;
            length = MyLineD.line.begin.distanceWithObject(end);
            return length;
        }
        public double getGradient()
        {
            double gradient = 0.0D;
            gradient = (MyLineD.line.end.getY() - MyLineD.line.begin.getY()) / (MyLineD.line.end.getX() - MyLineD.line.begin.getX());
            return gradient;
        }
    }
    
}

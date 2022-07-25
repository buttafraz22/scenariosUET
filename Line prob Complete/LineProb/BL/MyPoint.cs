using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineProb.BL
{
    class MyPoint
    {
        private int X;
        private int Y;
        public MyPoint()//no-arg constructor
        {
            X = 0;
            Y = 0;
        }
        public MyPoint(int X, int Y)// parametrized constructor
        {
            this.X = X;
            this.Y = Y;
        }
        public int getX()//getter function
        {
            return X;
        }
        public int getY()//getter function
        {
            return Y;
        }
        public void setXY(int X, int Y)// setter function
        {
            this.X = X;
            this.Y = Y;
        }
        public double distanceWithCords(int X , int Y)//returns distance with an object set as co-ordinates
        {
            double distance = 0.0D;
            distance = Math.Abs((Math.Pow((this.X - X),2)) + Math.Pow((this.Y - Y),2));
            distance = Math.Sqrt(distance);
            return distance;
        }
        public double distanceWithObject(MyPoint p)//returns distance with point as an object
        {
            double distance = 0.0D;
            distance = Math.Abs((Math.Pow((this.X - p.X), 2)) + Math.Pow((this.Y - p.Y), 2));
            distance = Math.Sqrt(distance);
            return distance;
        }
        public double distanceWithZero()//returns distance with zero point(0,0)
        {
            double distance = 0.0D;
            distance = Math.Abs((Math.Pow((this.X - 0), 2)) - Math.Pow((this.Y - 0), 2));
            distance = Math.Sqrt(distance);
            return distance;
        }
        public MyPoint(MyPoint P) // copy constructor
        {
            this.X = P.X;
            this.Y = P.Y;
        }
    }
}

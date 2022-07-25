using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameObject.BL
{
    class Point
    {
        public int X;
        public int Y;
        public Point()
        {
            X = 0;
            Y = 0;
        }
        public Point(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }
        public int getX()
        {
            return this.X;
        }
        public int getY()
        {
            return this.Y;
        }
        public void setX(int X)
        {
            this.X = X;
        }
        public void setY(int Y)
        {
            this.Y = Y;
        }
    }
}

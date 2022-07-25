using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacMan.BL
{
    class Cell
    {
        private char value;
        private int X;
        private int Y;

        public Cell()
        {

        }
        public Cell(char value , int x, int y)
        {
            this.value = value;
            this.X = x;
            this.Y = y;
        }
        public char getValue()
        {
            return value;
        }
        public int getX()
        {
            return X;
        }
        public int getY()
        {
            return Y;
        }
        public void setX(int X)
        {
            this.X = X;
        }
        public void setY(int Y)
        {
            this.Y = Y;
        }
        public void setValue(char value)
        {
            this.value = value;
        }
        public bool isPacmanPresent()
        {
            switch(value)
            {
                case 'P':
                    return true;
                default:
                    return false;
            }
        }
        public bool isGhostPresent(char ghostCharacter)
        {
            if(value == ghostCharacter)
            {
                return true;
            }
            return false;
        }
        public bool isCellPresent(Cell c)
        {
            if(c.value == value && c.X == X && c.Y == Y)
            {
                return true;
            }
            return false;
        }

    }
}

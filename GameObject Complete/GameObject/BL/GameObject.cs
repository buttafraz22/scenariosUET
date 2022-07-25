using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameObject.UI;

namespace GameObject.BL
{
    class GameObjectC
    {
        private char[,] shape;
        private Point startingPoint;
        private Boundary premises;
        private string direction;
        private string directionP = "Left";
        private int count = 0;

        public GameObjectC()
        {
            this.shape = new char[1, 3] { { '-', '-', '-' } };
            this.startingPoint = new Point();
            this.premises = new Boundary();
            this.direction = "leftToRight";
        }
        public GameObjectC(char[,] shape, Point startingPoint)
        {
            this.shape = shape;
            this.startingPoint = startingPoint;
            this.premises = new Boundary();
            this.direction = "leftToRight";
        }
        public GameObjectC(char[,] shape, Point startingPoint, Boundary premises, string direction)
        {
            this.shape = shape;
            this.startingPoint = startingPoint;
            this.premises = premises;
            this.direction = direction;
        }

        public void Move()
        {
            if (direction == "leftToRight")
            {
                if(startingPoint.X < 109)
                startingPoint.X++;
            }
            else if (direction == "rightToLeft")
            {
                if (startingPoint.X > 5)
                    startingPoint.X--;
            }
            else if (direction == "diagonal")
            {
                startingPoint.X++;
                startingPoint.Y++;
            }
            else if (direction == "patrol")
            {
                
                if (directionP == "Left")
                {
                    if (startingPoint.X == 0)
                    {
                        startingPoint.X = 2;
                        directionP = "Right";
                    }
                    startingPoint.X--;
                }
                else if (directionP == "Right")
                {
                    if (startingPoint.X == 110)
                    {
                        startingPoint.X = 109;
                        directionP = "Left";
                    }
                    startingPoint.X++;

                }
            }
            if(direction == "projectile")
            {
                if(count <= 5)
                {
                    startingPoint.X++;
                    startingPoint.Y--;
                }
                if(count > 5 && count <= 11)
                {
                    directionP = "left";
                    startingPoint.X++;

                }
                if(count > 11 && count <= 19)
                {
                    directionP = "diagonal";
                    startingPoint.X++;
                    startingPoint.Y++;
                }
                if(count == 20)
                {
                    directionP = "";
                }
            }
        }
        public void erase()
        {
            GameObjectUI.clear();
        }
        public void draw()
        {
            if (direction == "leftToRight" || direction == "rightToLeft")
            { 
                int Y = startingPoint.getY();
                int X = startingPoint.getX();
                GameObjectUI.printGameObject(shape, Y, X);
            }
            if(direction == "diagonal")
            {
                int Y = startingPoint.getY();
                int X = startingPoint.getX();
                GameObjectUI.printGameObject(shape, Y, X);
            }
            if (direction == "patrol")
            {
                int Y = startingPoint.getY();
                int X = startingPoint.getX();
                GameObjectUI.printGameObject(shape, Y, X);
            }
            if (direction == "projectile")
            {
                int Y = startingPoint.getY();
                int X = startingPoint.getX();
                GameObjectUI.printGameObject(shape, Y, X);
                count++;
            }
        }
    }
}

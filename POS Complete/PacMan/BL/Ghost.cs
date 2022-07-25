using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PacMan.BL;
using System.IO;
using PacMan.UI;

namespace PacMan.BL
{
    class Ghost
    {
        private int X;
        private int Y;
        private string ghostDirection;
        private char ghostCharacter;
        private float speed;
        private char previousItem;
        private float deltaChange;
        public Grid mazeGrid;

        public Ghost(int X, int Y, string ghostDirection, char ghostCharacter, float speed, char previousItem, Grid mazeGrid)
        {
            this.X = X;
            this.Y = Y;
            this.ghostDirection = ghostDirection;
            this.ghostCharacter = ghostCharacter;
            this.speed = speed;
            this.previousItem = previousItem;
            this.deltaChange = 0.0f;
            this.mazeGrid = mazeGrid;
        }
        public void setDirection(string ghostDirection)
        {
            this.ghostDirection = ghostDirection;
        }
        public string getDirection()
        {
            return ghostDirection;
        }
        public int getX()
        {
            return X;
        }
        public int getY()
        {
            return Y;
        }
        public void remove()
        {
            int X = getY();
            int Y = getX();
            GhostUI.removeGhost(X, Y);
        }
        public void draw()
        {
            GhostUI.printGhost(ghostCharacter);
        }
        public char getCharacter()
        {
            return ghostCharacter;
        }
        public void setDeltaZero()
        {
            deltaChange = 0.0f;
        }
        public float getDelta()
        {
            return deltaChange;
        }
        public void changeDelta()
        {
            deltaChange = deltaChange + speed;
        }
        public void move()
        {

            changeDelta();
            if (Math.Floor(deltaChange) == 1)
            {
                if (ghostCharacter == 'I')//Inky
                {
                    moveHorizontal(mazeGrid);
                }
                
                if(ghostCharacter == 'K')//Pinky
                {
                    moveVertical(mazeGrid);
                }
                if(ghostCharacter == 'B')//Blinky
                {
                    moveRandom(mazeGrid);
                }
                if(ghostCharacter == 'C')//Clyde
                {
                    moveSmart(mazeGrid);
                }
                setDeltaZero();
            }

        }
        // the  troublesome parts in the code
        public void moveHorizontal(Grid mazeGrid1)
        {
            Cell[,] mazeGrid = mazeGrid1.getGrid();
            if (ghostDirection == "left" || ghostDirection == "Left")
            {
                if (mazeGrid[X, Y - 1].getValue() != '|' || mazeGrid[X, Y - 1].getValue() != '%' || mazeGrid[X, Y - 1].getValue() == 'P')
                {
                    previousItem = mazeGrid[X, Y - 1].getValue();
                    //remove();
                    if (mazeGrid[X, Y - 1].getValue() == 'P')
                        previousItem = ' ';

                    mazeGrid[X, Y - 1].setValue(mazeGrid[X, Y].getValue());
                    //draw();

                    mazeGrid[X, Y].setValue(previousItem);

                    GhostUI.printItem(X, Y+1,previousItem);
                    Y--;
                }
                if (mazeGrid[X, Y - 1].getValue() == '|')
                {
                    ghostDirection = "right";
                }
            }
            if (ghostDirection == "right" || ghostDirection == "Right")
            {
                if (mazeGrid[X, Y + 1].getValue() != '|' || mazeGrid[X, Y + 1].getValue() != '%' || mazeGrid[X, Y - 1].getValue() == 'P')
                {
                    previousItem = mazeGrid[X, Y + 1].getValue();
                    if (mazeGrid[X, Y + 1].getValue() == 'P')
                        previousItem = ' ';

                    mazeGrid[X, Y + 1].setValue(mazeGrid[X, Y].getValue());
                    //draw();

                    mazeGrid[X, Y].setValue(previousItem);
                    //draw();
                    GhostUI.printItem(X, Y-1, ' ');
                    Y++;
                }
                if (mazeGrid[X, Y + 3].getValue() == '|')
                {
                    ghostDirection = "left";
                }
            }
        }
        public void moveVertical(Grid mazeGrid1)
        {

            Cell[,] mazeGrid = mazeGrid1.getGrid();
            if (ghostDirection == "up" || ghostDirection == "Up")
            {
                if (mazeGrid[X - 1, Y].getValue() != '#' || mazeGrid[X - 1, Y].getValue() != '%' || mazeGrid[X - 1, Y].getValue() == 'P')
                {
                    previousItem = mazeGrid[X - 1, Y].getValue();
                    //remove();
                    if (mazeGrid[X - 1, Y].getValue() == 'P')
                        previousItem = ' ';

                    mazeGrid[X - 1, Y].setValue(mazeGrid[X, Y].getValue());
                    //draw();

                    mazeGrid[X, Y].setValue(previousItem);

                    GhostUI.printItem(X, Y, ' ');
                    X--;
                }
                if (mazeGrid[X - 1, Y].getValue() == '#')
                {
                    ghostDirection = "down";
                }
            }
            if (ghostDirection == "down" || ghostDirection == "Down")
            {
                if (mazeGrid[X + 1, Y].getValue() != '#' || mazeGrid[X + 1, Y].getValue() != '%' || mazeGrid[X + 1, Y].getValue() == 'P')
                {
                    previousItem = mazeGrid[X + 1, Y].getValue();
                    //remove();
                    if (mazeGrid[X + 1, Y].getValue() == 'P')
                        previousItem = ' ';

                    mazeGrid[X + 1, Y].setValue(mazeGrid[X, Y].getValue());
                    //draw();

                    mazeGrid[X, Y].setValue(previousItem);

                    GhostUI.printItem(X, Y, ' ');
                    X++;
                }
                if (mazeGrid[X + 1, Y].getValue() == '#')
                {
                    ghostDirection = "up";
                }
            }
        }
        internal int generateRandom()
        {
            Random rnd = new Random();
            int rand = rnd.Next(1, 4);
            return rand;
        }
        public void moveRandom(Grid mazeGrid1)
        {
            Cell[,] mazeGrid = mazeGrid1.getGrid();
            int random = generateRandom();
            if(random == 1) // move down
            {
                if (mazeGrid[X + 2, Y].getValue() != '#' || mazeGrid[X + 2, Y].getValue() != '%' || mazeGrid[X + 2, Y].getValue() == 'P')
                {
                    previousItem = mazeGrid[X + 1, Y].getValue();
                    //remove();
                    if (mazeGrid[X + 1, Y].getValue() == 'P')
                        previousItem = ' ';

                    mazeGrid[X + 1, Y].setValue(mazeGrid[X, Y].getValue());
                    //draw();

                    mazeGrid[X, Y].setValue(previousItem);

                    GhostUI.printItem(X, Y, ' ');
                    X++;
                }
            }
            else if(random == 2) // move up
            {
                if (mazeGrid[X - 1, Y].getValue() != '#' || mazeGrid[X - 1, Y].getValue() != '%' || mazeGrid[X - 1, Y].getValue() == 'P')
                {
                    previousItem = mazeGrid[X - 1, Y].getValue();
                    //remove();
                    if (mazeGrid[X - 1, Y].getValue() == 'P')
                        previousItem = ' ';

                    mazeGrid[X - 1, Y].setValue(mazeGrid[X, Y].getValue());
                    //draw();

                    mazeGrid[X, Y].setValue(previousItem);

                    GhostUI.printItem(X, Y, ' ');
                    X--;
                }
            }
            else if(random == 3) // move  left
            {
                if (mazeGrid[X, Y - 1].getValue() != '|' || mazeGrid[X, Y - 1].getValue() != '%' || mazeGrid[X, Y - 1].getValue() == 'P')
                {
                    previousItem = mazeGrid[X, Y - 1].getValue();
                    //remove();
                    if (mazeGrid[X, Y - 1].getValue() == 'P')
                        previousItem = ' ';

                    mazeGrid[X, Y - 1].setValue(mazeGrid[X, Y].getValue());
                    //draw();

                    mazeGrid[X, Y].setValue(previousItem);

                    GhostUI.printItem(X, Y + 1, previousItem);
                    Y--;
                }
            }
            else if(random == 4) // move right
            {

                if (mazeGrid[X, Y + 1].getValue() != '|' || mazeGrid[X, Y + 1].getValue() != '%' || mazeGrid[X, Y + 1].getValue() == 'P')
                {
                    previousItem = mazeGrid[X, Y + 1].getValue();
                    if (mazeGrid[X, Y + 1].getValue() == 'P')
                        previousItem = ' ';

                    mazeGrid[X, Y + 1].setValue(mazeGrid[X, Y].getValue());
                    //draw();

                    mazeGrid[X, Y].setValue(previousItem);
                    //draw();
                    GhostUI.printItem(X, Y - 1, ' ');
                    Y++;
                }
            }
        }
        private double getLargestinArray(double [] arr)
        {
            double largest = int.MinValue;
            foreach( double i in arr)
            {
                if (i > largest)
                    largest = i;
            }
            return largest;
        }
        private double calculateDistance(Cell Current, Cell pacmanLocation)
        {
            return Math.Sqrt(Math.Pow((pacmanLocation.getX() - X), 2) + Math.Pow((pacmanLocation.getY() - Y), 2));
        }
        public void moveSmart(Grid mazeGrid1)
        {
            Cell[,] mazeGrid = mazeGrid1.getGrid();
            double[] distance = new double[4] { 0, 0, 0, 0 };
            Cell pacmanLocation = new Cell();
            foreach (Cell i in mazeGrid)
            {
                if (i != null)
                {
                    if (i.isPacmanPresent())
                    {
                        pacmanLocation = i;
                        break;
                    }
                }
            }
            string checker = " ";
            switch (checker)
            {
                case " ":
                    if (mazeGrid[X, Y - 1].getValue() != '|' && mazeGrid[X, Y - 1].getValue() != '%')
                        distance[0] = calculateDistance(mazeGrid[X, Y - 1], pacmanLocation);

                    if (mazeGrid[X, Y + 1].getValue() != '|' && mazeGrid[X, Y + 1].getValue() != '%')
                        distance[1] = calculateDistance(mazeGrid[X, Y - 1], pacmanLocation);

                    if (mazeGrid[X + 1, Y].getValue() != '|' && mazeGrid[X + 1, Y].getValue() != '%')
                        distance[2] = calculateDistance(mazeGrid[X, Y - 1], pacmanLocation);

                    if (mazeGrid[X - 1, Y].getValue() != '|' && mazeGrid[X - 1, Y].getValue() != '%')
                        distance[3] = calculateDistance(mazeGrid[X, Y - 1], pacmanLocation);
                    break;

                default:
                    checker = " ";
                    break;
            }
            if(getLargestinArray(distance) == distance[0])//move left
            {
                if (mazeGrid[X, Y - 1].getValue() != '|' || mazeGrid[X, Y - 1].getValue() != '%' || mazeGrid[X, Y - 1].getValue() == 'P')
                {
                    previousItem = mazeGrid[X, Y - 1].getValue();
                    //remove();
                    if (mazeGrid[X, Y - 1].getValue() == 'P')
                        previousItem = ' ';

                    mazeGrid[X, Y - 1].setValue(mazeGrid[X, Y].getValue());
                    //draw();

                    mazeGrid[X, Y].setValue(previousItem);

                    GhostUI.printItem(X, Y + 1, previousItem);
                    Y--;
                }
            }
            else if(getLargestinArray(distance) == distance[1])//move right
            {

                if (mazeGrid[X, Y + 1].getValue() != '|' || mazeGrid[X, Y + 1].getValue() != '%' || mazeGrid[X, Y + 1].getValue() == 'P')
                {
                    previousItem = mazeGrid[X, Y + 1].getValue();
                    if (mazeGrid[X, Y + 1].getValue() == 'P')
                        previousItem = ' ';

                    mazeGrid[X, Y + 1].setValue(mazeGrid[X, Y].getValue());
                    //draw();

                    mazeGrid[X, Y].setValue(previousItem);
                    //draw();
                    GhostUI.printItem(X, Y - 1, ' ');
                    Y++;
                }
            }
            else if(getLargestinArray(distance) == distance[2])//move up
            {
                if (mazeGrid[X + 2, Y].getValue() != '#' || mazeGrid[X + 2, Y].getValue() != '%' || mazeGrid[X + 2, Y].getValue() == 'P')
                {
                    previousItem = mazeGrid[X + 1, Y].getValue();
                    //remove();
                    if (mazeGrid[X + 1, Y].getValue() == 'P')
                        previousItem = ' ';

                    mazeGrid[X + 1, Y].setValue(mazeGrid[X, Y].getValue());
                    //draw();

                    mazeGrid[X, Y].setValue(previousItem);

                    GhostUI.printItem(X, Y, ' ');
                    X++;
                }
            }
            else if(getLargestinArray(distance) == distance[3])//move down
            {
                if (mazeGrid[X - 1, Y].getValue() != '#' || mazeGrid[X - 1, Y].getValue() != '%' || mazeGrid[X - 1, Y].getValue() == 'P')
                {
                    previousItem = mazeGrid[X - 1, Y].getValue();
                    //remove();
                    if (mazeGrid[X - 1, Y].getValue() == 'P')
                        previousItem = ' ';

                    mazeGrid[X - 1, Y].setValue(mazeGrid[X, Y].getValue());
                    //draw();

                    mazeGrid[X, Y].setValue(previousItem);

                    GhostUI.printItem(X, Y, ' ');
                    X--;
                }
            }

        }
    }
}

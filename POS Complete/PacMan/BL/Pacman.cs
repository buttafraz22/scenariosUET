using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PacMan.BL;
using System.IO;
using PacMan.UI;
using EZInput;

namespace PacMan.BL
{
    class Pacman
    {
        public int X;
        public int Y;
        public int score;
        public Grid mazeGrid;
        

        public Pacman(int X, int Y, Grid mazeGrid)
        {
            this.X = X;
            this.Y = Y;
            this.mazeGrid = mazeGrid;
            this.score = 0;
        }
        public void remove()
        {
            
            PacmanUI.remove(Y ,X);
        }
        public void draw()
        {
            PacmanUI.draw(Y, X);
        }
        public void moveLeft(Grid mazeGrid1)
        {
            Cell[,] mazeGrid = mazeGrid1.getGrid();
            if (mazeGrid[X, Y - 1].getValue() != '|' || mazeGrid[X, Y - 1].getValue() != '%' )
            {
               char  previousItem = mazeGrid[X, Y - 1].getValue();
                if (previousItem == '.')
                    score++;
        

                mazeGrid[X, Y - 1].setValue(mazeGrid[X, Y].getValue());

                mazeGrid[X, Y].setValue(previousItem);

                GhostUI.printItem(X, Y + 1, previousItem);// prints previous item
                Y--;
            }
        }
        public void moveRight(Grid mazeGrid1)
        {
            Cell[,] mazeGrid = mazeGrid1.getGrid();
            if (mazeGrid[X, Y + 2].getValue() != '|' || mazeGrid[X, Y + 2].getValue() != '%')
            {
                char previousItem = mazeGrid[X, Y + 1].getValue();
                if (previousItem == '.')
                    score++;
               

                mazeGrid[X, Y + 1].setValue(mazeGrid[X, Y].getValue());

                mazeGrid[X, Y].setValue(previousItem);

                GhostUI.printItem(X, Y - 1, previousItem);// prints previous item
                Y++;
            }
        }
        public void moveUp(Grid mazeGrid1)
        {
            Cell[,] mazeGrid = mazeGrid1.getGrid();
            if (mazeGrid[X - 2, Y].getValue() != '#' || mazeGrid[X - 2,Y].getValue() != '%')
            {
                char previousItem = mazeGrid[X - 1, Y ].getValue();
                if (previousItem == '.')
                    score++;
                

                mazeGrid[X-1, Y].setValue(mazeGrid[X, Y].getValue());

                mazeGrid[X, Y].setValue(previousItem);

                GhostUI.printItem(X + 1, Y, previousItem);// prints previous item
                X--;
            }
        }
        public void moveDown(Grid mazeGrid1)
        {
            Cell[,] mazeGrid = mazeGrid1.getGrid();
            if (mazeGrid[X + 2, Y].getValue() != '#' || mazeGrid[X + 2, Y].getValue() != '%')
            {
                char previousItem = mazeGrid[X + 1, Y].getValue();
                if (previousItem == '.')
                    score++;
               

                mazeGrid[X + 1, Y].setValue(mazeGrid[X, Y].getValue());

                mazeGrid[X, Y].setValue(previousItem);

                GhostUI.printItem(X - 1, Y, previousItem); // prints previous item
                X++;
            }
        }
        public void move()
        {
            if(Keyboard.IsKeyPressed(Key.LeftArrow))
            {
                moveLeft(mazeGrid);
            }
            if(Keyboard.IsKeyPressed(Key.RightArrow))
            {
                moveRight(mazeGrid);
            }
            if(Keyboard.IsKeyPressed(Key.UpArrow))
            {
                moveUp(mazeGrid);
            }
            if(Keyboard.IsKeyPressed(Key.DownArrow))
            {
                moveDown(mazeGrid);
            }
        }
        public void printScore()
        {
            PacmanUI.printNumber(score);
        }
    }
}

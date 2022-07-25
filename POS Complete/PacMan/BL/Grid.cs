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
    class Grid
    {
        private Cell[,] mazeGrid;
        private int rowSize;
        private int colSize;
        
        public Cell[,] getGrid()
        {
            return mazeGrid;
        }
        public Grid(int rowSize, int colSize,string path)
        {
            mazeGrid = new Cell[rowSize, colSize];
            this.rowSize = rowSize;
            this.colSize = colSize;

            // the read-and-fill operation
            StreamReader fp = new StreamReader(path);
            string record;
            int row = 0;
            while ((record = fp.ReadLine()) != null)
            {
                for (int x = 0; x < colSize - 2; x++)
                {
                    Cell obj = new Cell(record[x], row, x);
                    mazeGrid[row, x] = obj;
                }
                row++;
            }

            fp.Close();
        }
        public Cell getLeftCell(Cell c)
        {
            for(int i = 0; i < rowSize; i++)
            {
                for(int j = 0; j < colSize; j++)
                {
                    if(c.isCellPresent(mazeGrid[i,j]))
                    {
                        return mazeGrid[i, j - 1];
                    }
                }
            }
            return null;
        }
        public Cell getRightCell(Cell c)
        {
            for (int i = 0; i < rowSize; i++)
            {
                for (int j = 0; j < colSize; j++)
                {
                    if (c.isCellPresent(mazeGrid[i, j]))
                    {
                        return mazeGrid[i, j + 1];
                    }
                }
            }
            return null;
        }
        public Cell getDownCell(Cell c)
        {
            for (int i = 0; i < rowSize; i++)
            {
                for (int j = 0; j < colSize; j++)
                {
                    if (c.isCellPresent(mazeGrid[i, j]))
                    {
                        return mazeGrid[i + 1 , j];
                    }
                }
            }
            return null;
        }
        public Cell getUpCell(Cell c)
        {
            for (int i = 0; i < rowSize; i++)
            {
                for (int j = 0; j < colSize; j++)
                {
                    if (c.isCellPresent(mazeGrid[i, j]))
                    {
                        return mazeGrid[i - 1, j];
                    }
                }
            }
            return null;
        }
        public Cell findPacman()
        {
            for (int i = 0; i < rowSize; i++)
            {
                for (int j = 0; j < colSize; j++)
                {
                    if (mazeGrid[i,j].isPacmanPresent())
                    {
                        return mazeGrid[i , j];
                    }
                }
            }
            return null;
        }
        public Cell findGhost(char ghostCharacter)
        {
            for (int i = 0; i < rowSize; i++)
            {
                for (int j = 0; j < colSize; j++)
                {
                    if (mazeGrid[i, j].isGhostPresent(ghostCharacter))
                    {
                        return mazeGrid[i, j];
                    }
                }
            }
            return null;
        }
        public bool isStoppingCondition()
        {
            bool gameStop = false;
            for (int i = 0; i < rowSize; i++)
            {
                for (int j = 0; j < colSize; j++)
                {
                    if (mazeGrid[i, j] != null)
                    {
                        if (!mazeGrid[i, j].isPacmanPresent())
                        {
                            gameStop = true;
                            
                        }
                    }
                }
            }
            return gameStop;
        }
        public void draw()
        {
            GridUI.drawMaze(mazeGrid);
        }


    }
}

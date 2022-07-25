using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PacMan.BL;
using System.IO;
namespace PacMan.UI
{
    class GridUI
    {
        public static  void drawMaze(Cell [,] maze)
        {
            for(int i = 0; i < maze.GetLength(0); i++)
            {
                for(int j = 0; j < maze.GetLength(1); j++)
                {
                    Console.SetCursorPosition(j, i);
                    if (maze[i, j] != null)
                         Console.WriteLine(maze[i, j].getValue());
                }
            }
        }
    }
}

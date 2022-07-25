using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using PacMan.BL;
namespace PacMan
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initialization
            string path = "maze.txt";
            Grid mazeGrid = new Grid(24, 71, path);

            Pacman player = new Pacman(16, 43, mazeGrid);
            Ghost Inky = new Ghost(15, 39, "left", 'I', 0.1f, ' ', mazeGrid); // inky initialization
            Ghost Pinky = new Ghost(20, 57, "up", 'K', 0.8f, ' ', mazeGrid);//pinky initialization
            Ghost Blinky = new Ghost(16, 19, "right", 'B', 0.5f, ' ', mazeGrid);//blinky initialization
            Ghost Clyde = new Ghost(1, 9, "down", 'C', 0.6f, ' ', mazeGrid);//clyde initialization

            List<Ghost> enemies = new List<Ghost>(); // adding ghosts in list
            enemies.Add(Inky);
            enemies.Add(Pinky);
            enemies.Add(Clyde);
            enemies.Add(Blinky);

            mazeGrid.draw(); // drawing grid on console
            player.draw();   // drawing player on console

            bool gameRunning = true;

            do
            {

                Thread.Sleep(90);
                
                player.printScore(); // player related functions
                player.remove();
                player.move();
                player.draw();

                foreach(Ghost g in enemies)
                {
                    g.remove();
                    g.move();
                    g.draw();
                }

                if (!mazeGrid.isStoppingCondition())
                    gameRunning = false;
                
            } while (gameRunning);

        }
    }
}

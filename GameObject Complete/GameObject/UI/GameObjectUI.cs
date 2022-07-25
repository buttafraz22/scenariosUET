using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameObject.BL;

namespace GameObject.UI
{
    class GameObjectUI
    {
        public static void printGameObject(char[,] shape, int X,  int Y)
        {

                for (int i = 0; i < shape.GetLength(0); i++)
                {
                    for (int j = 0; j < shape.GetLength(1); j++)
                    {
                        Console.SetCursorPosition(Y+j, X+i);
                        Console.Write(shape[i, j]);
                    }
                }                
        }
       
        public static void clear()
        {
            Console.Clear();
        }
        
        
    }
}

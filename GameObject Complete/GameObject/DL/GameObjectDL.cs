using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameObject.BL;
using System.IO;

namespace GameObject.DL
{
    class GameObjectDL
    {
        
        public static bool WriteObjectInFile(char[,] shape)
        {
            StreamWriter file = new StreamWriter("dataObject.txt");
            for (int i = 0; i < shape.GetLength(0); i++)
            {
                for (int j = 0; j < shape.GetLength(1); j++)
                {
                    file.Write(shape[i, j]);
                }
                file.WriteLine();
            }
            file.Close();
            return true;
        }
        
            public static char [,] readData(char[,] maze)
            {
                StreamReader fp = new StreamReader("dataObject.txt");
                string record;
                int row = 0;
                while ((record = fp.ReadLine()) != null)
                {
                    for (int x = 0; x < 3; x++)
                    {
                        maze[row, x] = record[x];
                    }
                    row++;
                }

                fp.Close();
                return maze;
            }

    }
}

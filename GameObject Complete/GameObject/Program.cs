using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using GameObject.BL;
using GameObject.UI;
using GameObject.DL;
namespace GameObject
{
    class Program
    {
        public static void Main()
        {
            char[,] pentoid = new char[,] { { ' ', '@', ' ' }, { '@', ' ', '@' }, { '@', '@', '@' }, { '@', '#', '%' }, { '$', '&', '$' } };
            Boundary b = new Boundary();
            char[,] testFile = new char[5, 3]; GameObjectDL.readData(testFile);

            GameObjectC g = new GameObjectC(pentoid, new Point(0, 0), b, "patrol");
            GameObjectC f = new GameObjectC(testFile, new Point(10, 10), b, "projectile");

            List<GameObjectC> cross = new List<GameObjectC>();
            cross.Add(g);
            cross.Add(f);
            while (true)
            {
                GameObjectDL.WriteObjectInFile(pentoid);
                foreach (GameObjectC i in cross)
                {
                    i.Move();
                    i.draw();
                    
                    Thread.Sleep(200);
                }
                g.erase();
            }
        }
    }
}

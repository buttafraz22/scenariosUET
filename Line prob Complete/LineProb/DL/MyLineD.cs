using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LineProb.BL;
using System.IO;
namespace LineProb.DL
{
    class MyLineD
    {
        public static MyLine line;
        public  static bool writeLineinFile()
        {
            StreamWriter file = new StreamWriter("dataLine.txt");
            file.WriteLine(line.getBegin().getX()+","+line.getBegin().getY());
            file.WriteLine(line.getEnd().getY()+","+line.getEnd().getY());
            file.Flush();
            file.Close();
            return true;
        }
        public static bool loadFromFile()
        {
            StreamReader file = new StreamReader("dataLine.txt");
            if(File.Exists("dataLine.txt"))
            {
                string item = "";
                int count = 0;
                MyLine test = new MyLine();
                while((item = file.ReadLine()) != null)
                {
                    MyPoint point = new MyPoint();
                    string [] record = item.Split(',');
                    point.setXY(int.Parse(record[0]) , int.Parse(record[1]));
                    
                    if(count == 0)
                    {
                        test.setBegin(point);
                        //MyLineD.line.begin.Y = point.Y;
                    }
                    else if(count == 1)
                    {
                        test.setEnd(point);
                        //MyLineD.line.end.Y = point.Y;
                    }
                    count++;
                }
                line = test;
                file.Close();
            }
            return true;
        }
        public static MyPoint getLineBegin()
        {
            return line.getBegin();
        }
        public static MyPoint getLineEnd()
        {
            return line.getEnd();
        }
        public static  void setLineBegin(MyPoint begin)
        {
            line.setBegin(begin) ;
        }
        public static void setLineEnd(MyPoint end)
        {
            line.setEnd(end);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LineProb.BL;
using LineProb.DL;
using LineProb.UI;
namespace LineProb
{
    class Program
    {
        static void Main(string[] args)
        {
            string option = "";
            MyPoint copyBegin = new MyPoint();
            MyPoint copyEnd = new MyPoint();
            while (true)
            {
                MyLineD.loadFromFile();
                Console.Clear();
                option = UserI.menu();
                if(option == "1")//make a line
                {
                    int X = 0, Y = 0;
                    MyLineD.line = MyLineUI.makeALine();

                    X = MyLineD.line.getBegin().getX();
                    Y = MyLineD.line.getBegin().getY();
                    copyBegin.setXY(X, Y);

                    X = MyLineD.line.getEnd().getX();
                    Y = MyLineD.line.getEnd().getY();
                    copyEnd.setXY(X, Y);

                    MyLineD.writeLineinFile();
                    UserI.clear();
                }
                if (option == "2")//update begin point
                {
                    int x = 0, y = 0;
                    UserI.getValues(ref x, ref y);
                    MyPoint updateBegin = new MyPoint(x,y);
                    MyLineD.setLineBegin(updateBegin);
                    MyLineD.writeLineinFile();
                    UserI.clear();
                }
                if (option == "3")//update end point
                {
                    int x = 0, y = 0;
                    UserI.getValues(ref x, ref y);
                    MyPoint updateEnd = new MyPoint(x, y);
                    MyLineD.setLineEnd(updateEnd);
                    MyLineD.writeLineinFile();
                    UserI.clear();
                }
                if (option == "4")//show update begin point
                {
                    UserI.showUpdate(MyLineD.line.getBegin());
                    UserI.clear();
                }
                if (option == "5")//show update end point
                {
                    UserI.showUpdate(MyLineD.line.getEnd());
                    UserI.clear();
                }
                if (option == "6")//length of the line
                {
                    double length = MyLineD.line.getLength();
                    UserI.printValue(length);
                    UserI.clear();
                }
                if (option == "7") //gradient of the line
                {
                    double gradient = MyLineD.line.getGradient();
                    UserI.printValue(gradient);
                    UserI.clear();
                }
                if (option == "8")// distance of begin point from zero cordinates
                {
                    double distance = MyLineD.line.getBegin().distanceWithObject(copyBegin);
                    UserI.printValue(distance);
                    UserI.clear();
                }
                if (option == "9") // distance of end point from zero cordinates
                {
                    double distance = MyLineD.line.getEnd().distanceWithObject(copyEnd);
                    UserI.printValue(distance);
                    UserI.clear();
                }
                if (option == "10")
                    break;   
            }
        }
       
    }
}

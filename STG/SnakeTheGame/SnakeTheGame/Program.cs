using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SnakeTheGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point();
            p1.x = 1;
            p1.y = 3;
            p1.sym = '*';
            p1.Draw();

            /* int x1 = 1;
             int y1 = 2;
             char sym1 = '*';
             Draw(x1, y1, sym1);*/

            Point p2 = new Point();
            p2.x = 4;
            p2.y = 5;
            p2.sym = '@';
            p2.Draw();

            /*int x2 = 3;
            int y2 = 4;
            char sym2 = '@';
            Draw(x2, y2, sym2);*/

            Point p3 = new Point();
            p3.x = 7;
            p3.y = 9;
            p3.sym = '*';
            p3.Draw();

            /*int x3 = 5;
            int y3 = 6;
            char sym3 = '#';
            Draw(x3, y3, sym3);*/

            Console.ReadLine();
        }
        static void Draw(int x, int y, char sym)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}
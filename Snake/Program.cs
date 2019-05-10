using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {

        static void Main(string[] args)
        {
            Point p1 = new Point(1, 4, '*');
            Point p2 = new Point(6, 8, '*');
            p1.Draw();
            List<Point> plist = new List<Point>();
            plist.Add(p1);
            plist.Add(p2);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Draw(int x, int y, char sym)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
        static void Main(string[] args)
        {
            Random r = new Random();

            for (int i = 0; i < 100; i++)
            {
                int a = r.Next(50);
                int b = r.Next(50);
                char c = ('*');
                Draw(a, b, c);
            }

        }
    }
}

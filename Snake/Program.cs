﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 26);
            HorizontalLines linexu = new HorizontalLines(0, 78, 1, '+');
            linexu.Draw();
            HorizontalLines linexd = new HorizontalLines(0, 78, 25, '+');
            linexd.Draw();
            VertikalLines lineyl = new VertikalLines(1, 25, 0, '+');
            lineyl.Draw();
            VertikalLines lineyr = new VertikalLines(1, 25, 78, '+');
            lineyr.Draw();
            Console.SetCursorPosition(1, 5);
            Point p = new Point(14, 14, '+');
            Snake snake = new Snake(p, 6, Direction.RIGHT);
            snake.Draw();
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            //Console.ReadKey();
        }
    }
}

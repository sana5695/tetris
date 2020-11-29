﻿using System;

namespace tetris
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(40, 30);
            Console.SetBufferSize(40, 30);
            int x1 = 2;
            int y1 = 2;
            int x2 = 3;
            int y2 = 2;
            char c1 = '*';
            Drow(x1, y1, c1);
            Drow(x2, y2, c1);
            Console.ReadLine();
        }
        static void Drow(int x, int y, char c)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(c);
        }
    }
}

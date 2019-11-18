using System;
using System.Collections.Generic;

namespace Lesson_4_Lib
{
    public class Horse
    {
        public int[,] Desk { get; private set; }
        int height;
        int width;
        int steps;

        public Horse(int a, int b)
        {
            height = b;
            width = a;
            Desk = new int[height, width];
            steps = 1;
            Run();
        }

        void Run()
        {
            int a;
            int b;
            Random rnd = new Random();
            //while(true)
            FindNext(1, 1);
            {
                FindNext(rnd.Next(0,width+1), rnd.Next(height+1));
            }
            
        }

        void FindNext(int a, int b)
        {
            Desk[a, b] = steps;
            PrintDesk();
            if (IsPossibly(a-2, b+1)) { steps++; FindNext(a-2, b+1); }
            if (IsPossibly(a-1, b+2)) { steps++; FindNext(a-1, b+2); }
            if (IsPossibly(a+1, b+2)) { steps++; FindNext(a+1, b+2); }
            if (IsPossibly(a+2, b+1)) { steps++; FindNext(a+2, b+1); }
            if (IsPossibly(a+2, b-1)) { steps++; FindNext(a+2, b-1); }
            if (IsPossibly(a+1, b-2)) { steps++; FindNext(a+1, b-2); }
            if (IsPossibly(a-1, b-2)) { steps++; FindNext(a-1, b-2); }
            if (IsPossibly(a-2, b-1)) { steps++; FindNext(a-2, b-1); }

            if (steps == height*width) PrintDesk();
            
            Desk[a, b] = 0;
            if(steps > 1) steps--;

            return;

            
        }

        bool IsPossibly(int x, int y)
        {
            if (x < 0 || x >= height) return false;
            if (y < 0 || y >= width) return false;
            if (Desk[x, y] != 0) return false;
            return true;
        }

        void PrintDesk()
        {
            Console.Clear();
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if(Desk[i, j] == 0) Console.Write("{0,3}","*");
                    else Console.Write($"{Desk[i, j],3}");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrix
{
    class Program
    {
        static Point point;
        static void Main(string[] args)
        {
            point.X=0;
            point.Y=0;
            int[,] matrix = new int[8, 8];

            matrix[point.X, point.Y] = 1;
            matrix[3, 4] = 0;
            matrix[3, 5] = 0;
            InitMatrix(matrix);


            PrintMatrix(matrix);
            Console.ReadKey();
        }

        static void PrintMatrix(int[,] matrix)
        {
            Console.Clear();
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Console.Write($"{matrix[i, j]}\t");
                }
                Console.WriteLine();

            }
        }

        static void InitMatrix(int[,] matrix)
        {
            for (int j = 0; j < 8; j++)
            {
                matrix[0, j] = 1;
            }
            for (int i = 1; i < 8; i++)
            {
                matrix[i, 0] = 1;
                for (int j = 1; j < 8; j++)
                {
                    matrix[i, j] = matrix[i, j-1] + matrix[i-1, j];
                }
            }
        }
    }
}

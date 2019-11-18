using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4_Lib
{
    public class MatrixPlantly
    {
        public int[] PlantlyA { get; private set; }
        public int[] PlantlyB { get; private set; }
        public int[,] MatrixPl { get; private set; }

        public MatrixPlantly(int[] a, int[] b)
        {
            this.PlantlyA = a;
            this.PlantlyB = b;
            MatrixInit();
            //MatrixCalc();
            PrintMatrix(MatrixCalc(MatrixPl));
        }

        void MatrixInit()
        {
            this.MatrixPl = new int[PlantlyA.Length+1, PlantlyB.Length+1];
            for (int j = 1; j < PlantlyB.Length+1; j++)
            {
                MatrixPl[0, j] = PlantlyB[j-1];
            }
            for (int i = 1; i < PlantlyA.Length+1; i++)
            {
                MatrixPl[i, 0] = PlantlyA[i-1];
            }
        }

        int[,] MatrixCalc(int[,] matr)
        {
            int[,] matrA = (int[,])matr.Clone();
            int[,] matrB = (int[,])matr.Clone();
            int temp =0;
            int scoreA = 0;
            int scoreB = 0;
            for (int i = 1; i < PlantlyA.Length+1; i++)
            {
                for (int j = i; j < PlantlyB.Length+1; j++)
                {
                    if (matrA[i, 0] == matrA[0, j])
                    {
                        scoreA++;
                        temp = matrA[i, 0];
                        for (int k = i; k < PlantlyA.Length+1; k++) matrA[k, j] = temp;
                        for (int l = j; l < PlantlyB.Length+1; l++) matrA[i, l] = temp;
                        i++;
                    }
                    else
                    {
                        for (int k = i; k < PlantlyA.Length+1; k++) matrA[k, j] = temp;
                        for (int l = j; l < PlantlyB.Length+1; l++) matrA[i, l] = temp;
                    }
                }
            }

            for (int j = 1; j < PlantlyB.Length+1; j++)
            {
                for (int i = j; i < PlantlyA.Length+1; i++)
                {
                    if (matrB[i, 0] == matrB[0, j])
                    {
                        scoreB++;
                        temp = matrB[0, j];
                        for (int l = j; l < PlantlyB.Length+1; l++) matrB[i, l] = temp;
                        for (int k = i; k < PlantlyA.Length+1; k++) matrB[k, j] = temp;
                        j++;
                    }
                    else
                    {
                        for (int l = j; l < PlantlyB.Length+1; l++) matrB[i, l] = temp;
                        for (int k = i; k < PlantlyA.Length+1; k++) matrB[k, j] = temp;
                    }
                }
            }


            if (scoreA > scoreB) return matrA;
            else return matrB;
        }

        void PrintMatrix(int[,] matr)
        {
            Console.Clear();
            for (int j = 0; j < matr.Length/matr.GetLength(0); j++)
            {
                if (j <= 1) Console.ForegroundColor = ConsoleColor.Green;
                else Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("-----------------");
                if (j <= 1) Console.ForegroundColor = ConsoleColor.Green;
                else Console.ResetColor();
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("|");
                Console.ResetColor();
                for (int i = 0; i < matr.GetLength(0); i++)
                {
                    if (i == 0 || j == 0) Console.ForegroundColor = ConsoleColor.Green;
                    else Console.ResetColor();
                    Console.Write(string.Format("\t{0:0}\t|", matr[i, j]));
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("-----------------");
            Console.ResetColor();
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------");
        }
    }
}

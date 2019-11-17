using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4_Lib
{
    public class Task1
    {
        /// <summary>
        /// Матрица значений количества путей
        /// </summary>
        int[,] matrix;

        /// <summary>
        /// Матрица поля разрешенных клеток
        /// </summary>
        int[,] desk;

        /// <summary>
        /// Ширина поля
        /// </summary>
        int width;

        /// <summary>
        /// Высота поля
        /// </summary>
        int height;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="w">Ширина поля</param>
        /// <param name="h">Высота поля</param>
        public Task1(int w, int h)
        {
            this.width = w;
            this.height = h;
            this.matrix = new int[w, h];
            this.desk = new int[w, h];

        }

        /// <summary>
        /// Рассчитывает и заполняет матрицу ходов, с учетом препядствий
        /// </summary>
        /// <param name="matrix">Матрица количества ходов</param>
        /// <param name="desk">Матрица поля с препядствиями</param>
        public void MatrixCalc(ref int[,] matrix, int[,] desk)
        {
            for (int j = 0; j < height; j++)
            {
                matrix[0, j] = 1;
            }
            for (int i = 1; i < width; i++)
            {
                matrix[i, 0] = 1;
                for (int j = 1; j < height; j++)
                {
                    matrix[i, j] = matrix[i, j-1] + matrix[i-1, j];
                }
            }
        }
    }
}

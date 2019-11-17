using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4_Lib
{
    public class Matrix
    {
        /// <summary>
        /// Матрица значений количества путей
        /// </summary>
        public int[,] Moves { get; private set; }
        public int[,] Desk { get; set; }

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
        public Matrix(int h, int w)
        {
            this.width = w;
            this.height = h;
            this.Moves = new int[h, w];
            this.Desk = new int[h, w];
            this.DeskInit();
            
        }

        /// <summary>
        /// Рассчитывает и заполняет матрицу ходов, с учетом препядствий
        /// </summary>
        /// <param name="matrix">Матрица количества ходов</param>
        /// <param name="desk">Матрица поля с препядствиями</param>
        public void MatrixCalc(int n , int m)
        {
            for (int j = 0; j < height; j++)
            {
                Moves[0, j] = 1;
            }
            for (int i = 1; i < width; i++)
            {
                Moves[i, 0] = 1;
                for(int j = 1; j < height; j++)
                {
                    if (Desk[i, j] ==1)
                    {
                        Moves[i, j] = Moves[i, j-1] + Moves[i-1, j];
                    }
                    else if((Desk[i, j] ==-1)) Moves[i, j] = -1;
                    else Moves[i, j] = 0;
                }
            }
        }

        /// <summary>
        /// Заполняет матрицу поля единицами (все поля разрешены для ходов)
        /// </summary>
        private void DeskInit()
        {
            for (int j = 0; j < height; j++)
            {
                for (int i = 0; i < width; i++)
                {
                    this.Desk[i, j]= 1;
                }
            }
        }

        
    }
}

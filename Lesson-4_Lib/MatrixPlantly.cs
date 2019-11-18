namespace Lesson_4_Lib
{
    /// <summary>
    /// Нахождение наибольшей подпоследовательности матричным способом
    /// </summary>
    public class MatrixPlantly
    {
        /// <summary>
        /// Последовательность А
        /// </summary>
        int[] plantlyA;

        /// <summary>
        /// Последовательность Б
        /// </summary>
        int[] plantlyB;

        /// <summary>
        /// Длина максимальной Последовательности
        /// </summary>
        int length;

        /// <summary>
        /// Матрица пересечения Последовательностей
        /// </summary>
        public int[,] MatrixPl { get; private set; }

        /// <summary>
        /// Конструктор матрицы Последовательностей
        /// </summary>
        /// <param name="a">Последовательность А</param>
        /// <param name="b">Последовательность Б</param>
        public MatrixPlantly(int[] a, int[] b)
        {
            this.plantlyA = a;
            this.plantlyB = b;
            MatrixInit();
        }

        /// <summary>
        /// Запускает расчет
        /// </summary>
        public int Run()
        {
            MatrixPl = MatrixCalc();
            return length;
        }

        /// <summary>
        /// Заполняет матрицу начальными значениями
        /// </summary>
        void MatrixInit()
        {
            this.MatrixPl = new int[plantlyA.Length+1, plantlyB.Length+1];
            for (int j = 1; j < plantlyB.Length+1; j++)
            {
                MatrixPl[0, j] = plantlyB[j-1];
            }
            for (int i = 1; i < plantlyA.Length+1; i++)
            {
                MatrixPl[i, 0] = plantlyA[i-1];
            }
        }

        /// <summary>
        /// Находит максимальное подмножество
        /// </summary>
        /// <param name="matr">матрица пересечения двух множеств</param>
        /// <returns></returns>
        int[,] MatrixCalc()
        {
            int[,] matrA = (int[,])MatrixPl.Clone();
            int[,] matrB = (int[,])MatrixPl.Clone();
            int temp =0;
            int scoreA = 0;
            int scoreB = 0;
            for (int i = 1; i < plantlyA.Length+1; i++)
            {
                for (int j = i; j < plantlyB.Length+1; j++)
                {
                    if (matrA[i, 0] == matrA[0, j])
                    {
                        scoreA++;
                        temp = matrA[i, 0];
                        for (int k = i; k < plantlyA.Length+1; k++) matrA[k, j] = temp;
                        for (int l = j; l < plantlyB.Length+1; l++) matrA[i, l] = temp;
                        i++;
                    }
                    else
                    {
                        for (int k = i; k < plantlyA.Length+1; k++) matrA[k, j] = temp;
                        for (int l = j; l < plantlyB.Length+1; l++) matrA[i, l] = temp;
                    }
                }
            }

            for (int j = 1; j < plantlyB.Length+1; j++)
            {
                for (int i = j; i < plantlyA.Length+1; i++)
                {
                    if (matrB[i, 0] == matrB[0, j])
                    {
                        scoreB++;
                        temp = matrB[0, j];
                        for (int l = j; l < plantlyB.Length+1; l++) matrB[i, l] = temp;
                        for (int k = i; k < plantlyA.Length+1; k++) matrB[k, j] = temp;
                        j++;
                    }
                    else
                    {
                        for (int l = j; l < plantlyB.Length+1; l++) matrB[i, l] = temp;
                        for (int k = i; k < plantlyA.Length+1; k++) matrB[k, j] = temp;
                    }
                }
            }
            if (scoreA > scoreB) { length = scoreA; return matrA; }
            else { length = scoreB; return matrB; }
        }
    }
}

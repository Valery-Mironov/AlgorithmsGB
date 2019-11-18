/* Антон Алиев
 * Алгоритмы, домашнее задание к уроку 4. 
 * 
 * Задание 1*
 * Количество маршрутов с препятствиями. Реализовать чтение массива с препятствием и нахождение количество маршрутов.
 * 
 * Задание 2
 * Решить задачу о нахождении длины максимальной подпоследовательности с помощью матрицы.
 * 
 * Задание 3***
 * Требуется обойти конём шахматную доску размером N × M, пройдя через все поля доски по одному разу.
 * Здесь алгоритм решения такой же, как и в задаче о 8 ферзях. Разница только в проверке положения коня.
 * 
 */

using Lesson_4_Lib;
using System;

namespace Lesson_4
{
    /// <summary>
    /// Консольный пользовательский интерфейс
    /// </summary>
    public class Tasks
    {
        #region Messages
        static string msg1 = "Задание 1\nПопробовать оптимизировать пузырьковую сортировку.\n" +
            "Сравнить количество операций сравнения оптимизированной и неоптимизированной программы.\n" +
            "Написать функции сортировки, которые возвращают количество операций.";

        static string msg2 = "Задание 2*\nРаелизовать шейкерную сортировку";

        static string msg3 = "Задание 3\nРеализовать бинарный алгоритм поиска в виде функции, которой передаётся отсортированный массив.\n" +
            "Функция возвращает индекс найденного элемента или –1, если элемент не найден.";

        static string msg4 = "4. *Подсчитать количество операций для каждой из сортировок и сравнить его с асимптотической сложностью алгоритма.\n";
        #endregion
        string[] message;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="numTests">количество тестов</param>
        /// <param name="testArrLength">длина массива</param>
        public Tasks(string[] msgs)
        {
            message = msgs;
        }

        /// <summary>
        /// Демонстрация решения задачи 1
        /// </summary>
        public void Task1(int height, int width)
        {
            Matrix matr = new Matrix(height, width);

            ConsoleIO_Lib.ConsolIO.Greeting(this.message[0]);

            matr.Desk[3, 4] = -1;
            matr.Desk[4, 4] = -1;
            matr.Desk[3, 5] = -1;
            matr.MatrixCalc(0, 0);

            PrintResult(matr);
            ConsoleIO_Lib.ConsolIO.PauseClear();
        }

        /// <summary>
        /// Выводит в консоль матрицу поля и матрицу количества ходов
        /// </summary>
        /// <param name="matr"></param>
        private void PrintResult(Matrix matr)
        {
            Console.Clear();
            PrintMatrix(matr.Desk, "Таблица поля ходов");
            Console.WriteLine("\n\n");
            PrintMatrix(matr.Moves, "Таблица возможных ходов");
            Console.WriteLine();
        }

        /// <summary>
        /// Выводит в консоль матрицу в табличном виде
        /// </summary>
        /// <param name="matrix"></param>
        /// <param name="msg"></param>
        public void PrintMatrix(int[,] matrix, string msg)
        {
            Console.SetCursorPosition((Console.WindowWidth - msg.Length) /2-6, Console.CursorTop);
            Console.WriteLine($"- = {msg} = -");
            for (int j = 0; j < matrix.Length/matrix.GetLength(0); j++)
            {
                Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------");
                Console.Write("|");
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    if (matrix[i, j] < 0) Console.Write(string.Format("\t{0:0}\t|", "X"));
                    else if (matrix[i, j] == 0) Console.Write(string.Format("\t{0:0}\t|", 0));
                    else Console.Write(string.Format("\t{0:0}\t|", matrix[i, j]));
                }
                Console.WriteLine();
            }
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------");
        }

        /// <summary>
        /// Демонстрация решения задачи 2
        /// </summary>
        public void Task2()
        {
            ConsoleIO_Lib.ConsolIO.Greeting(message[1]);

            MatrixPlantly matrixPlantly = new MatrixPlantly(new int[] {1,5,2,4,9,7,3 }, new int[] {1,5,3,2,5,6,9,7 });

            ConsoleIO_Lib.ConsolIO.PauseClear();
        }

        /// <summary>
        /// Демонстрация решения задачи 3
        /// </summary>
        public void Task3()
        {
            ConsoleIO_Lib.ConsolIO.Greeting(message[2]);

            ConsoleIO_Lib.ConsolIO.PauseClear();
        }
    }
}

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

/// <summary>
/// Библиотека практических заданий к уроку 4 курса "алгоритмы"
/// </summary>
namespace Lesson_4
{
    /// <summary>
    /// Консольный пользовательский интерфейс
    /// </summary>
    public class Tasks
    {
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
        public void Task1()
        {
            Matrix matr = new Matrix();
            ConsoleIO_Lib.ConsolIO.Greeting(this.message[1]);

            // формирование препятствий
            matr.Desk[2, 4] = -1;
            matr.Desk[3, 3] = -1;
            matr.Desk[3, 4] = -1;
            matr.Desk[4, 4] = -1;
            matr.Desk[3, 5] = -1;

            matr.Run();

            ConsoleIO_Lib.ConsolIO.PrintMatrix(matr.Desk, "Таблица поля ходов с препятствиями");
            Console.WriteLine("\n");
            ConsoleIO_Lib.ConsolIO.PrintMatrix(matr.Moves, "Таблица количества ходов");
            Console.WriteLine("Нажмите любую клавишу...");

            Console.ReadKey();
        }

        /// <summary>
        /// Демонстрация решения задачи 2
        /// </summary>
        public void Task2()
        {
            int[] a = new int[] { 1, 5, 2, 4, 9, 7, 3 };
            int[] b = new int[] { 1, 5, 3, 2, 5, 6, 9, 7 };

            ConsoleIO_Lib.ConsolIO.Greeting(message[2]);
            int length;
            MatrixPlantly matrixPlantly = new MatrixPlantly(a, b);
            length = matrixPlantly.Run();

            ConsoleIO_Lib.ConsolIO.PrintMatrix(matrixPlantly.MatrixPl);
            Console.WriteLine($"\nДлина максимальной подпоследовательности = {length} \n");

            ConsoleIO_Lib.ConsolIO.PauseClear();
        }

        /// <summary>
        /// Демонстрация решения задачи 3
        /// </summary>
        public void Task3()
        {
            ConsoleIO_Lib.ConsolIO.Greeting(message[3]);
            ConsoleKeyInfo key;

            Horse horse = new Horse(8, 8);
            horse.result = new Horse.Result(ConsoleIO_Lib.ConsolIO.PrintDesk);
            horse.Run(0,0);
        }
    }
}

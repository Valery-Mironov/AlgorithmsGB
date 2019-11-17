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

using Lesson_4;
using System;

namespace MainMenu
{
    public static class Program
    {
        public static string[] tasksMsg = new string[]
                {
                    "Задание 1*\nКоличество маршрутов с препятствиями.\nРеализовать чтение массива с препятствием и нахождение количество маршрутов.",
                    "Задание 2\nРешить задачу о нахождении длины максимальной подпоследовательности с помощью матрицы.",
                    "Задание 3***\nТребуется обойти конём шахматную доску размером N × M, пройдя через все поля доски по одному разу.\n" +
                    "Здесь алгоритм решения такой же, как и в задаче о 8 ферзях. Разница только в проверке положения коня.",
                };
        public static Tasks tasks = new Tasks(tasksMsg);
        static void Main(string[] args)
        {
            Console.WindowWidth = 130;
            Console.WindowHeight = 42;
            int numb;
            do
            {
				Console.Clear();
				Console.WriteLine("Антон Алиев\tДомашнее задание к уроку 4\tКурс Алгоритмы GB\n");

				foreach(string msg in tasksMsg) Console.WriteLine(msg + "\n");

                Console.WriteLine($"Для демонстрации решения задачи - ввдете номер задачи и нажмите \"Enter\"\nДля выхода введите - 0\n");

                numb = ConsoleIO_Lib.ConsolIO.GetNumber();
				switch (numb)
                {
                    case 0: break;
                    case 1:
                        tasks.Task1(8,8);
                        break;
                    case 2:
                        tasks.Task2();
                        break;
                    case 3:
                        tasks.Task3();
                        break;
                    default: { Console.WriteLine($"В решении нет задачи с номером {numb}..."); Console.ReadKey(); continue; }
                }
            }
            while (numb !=0);
        }
    }
}

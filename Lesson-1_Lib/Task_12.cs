/* Антон Алиев
 * Алгоритмы, урок 1, задание 12
 * 
 * Написать функцию нахождения максимального из трёх чисел
 */
using System;

namespace Lesson_1_Lib
{
    public static class Task_12
    {
        public static void Run()
        {
            Console.WriteLine("Написать функцию нахождения максимального из трёх чисел\n");
            Console.WriteLine("Введите поочередно три целых числа:");
            int a = ConsoleIO_Lib.ConsolIO.GetNumber("первое число");
            int b = ConsoleIO_Lib.ConsolIO.GetNumber("второе число");
            int c = ConsoleIO_Lib.ConsolIO.GetNumber("третье число");

            Console.WriteLine($"Максимальным из введенных чисел является {MaxNumber(a, b, c)}");
            ConsoleIO_Lib.ConsolIO.PauseClear();
        }

        /// <summary>
        /// Возвращает максимальное из трех целых чисел
        /// </summary>
        /// <param name="a">первое число</param>
        /// <param name="b">второе число</param>
        /// <param name="c">третье число</param>
        /// <returns></returns>
        static int MaxNumber(int a, int b, int c)
        {
            if (a > b)
            {
                if (a > c) return a;
                else return c;
            }
            else if (b > c) return b;
            return c;
        }
    }
}

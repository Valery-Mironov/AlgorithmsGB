/* Антон Алиев
 * Алгоритмы, урок 1, задание 10*
 * 
 * Дано целое число N > 0. С помощью операций деления нацело и взятия остатка от деления определить,
 * имеются ли в записи числа N нечётные цифры.
 * Если имеются, то вывести True, если нет – вывести False
 */

using System;

namespace Lesson_1_Lib
{
    public static class Task_10
    {
        public static void Run()
        {
            Console.WriteLine("Дано целое число N > 0. С помощью операций деления нацело и взятия остатка от деления определить,\n" +
                "имеются ли в записи числа N нечётные цифры.\n" +
                "Если имеются, то вывести True, если нет – вывести False\n");
            int numb = ConsoleIO_Lib.ConsolIO.GetNumber("целое число");
            Console.WriteLine(IsHaveOddDigit(numb));
            ConsoleIO_Lib.ConsolIO.PauseClear();
        }

        /// <summary>
        /// Возвращает признак наличия в числе нечетных цифр
        /// </summary>
        /// <param name="numb"></param>
        /// <returns></returns>
        static bool IsHaveOddDigit(int numb)
        {
            if (numb % 2 != 0) return true;
            else if (numb >= 10) IsHaveOddDigit(numb /= 10);
            return false;
        }
    }
}

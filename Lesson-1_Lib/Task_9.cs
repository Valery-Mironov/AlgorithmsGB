/* Антон Алиев
 * Алгоритмы, урок 1, задание 9
 * 
 * Даны целые положительные числа N и K. Используя только операции сложения и вычитания, 
 * найти частное от деления нацело N на K, а также остаток от этого деления.
 */

using System;

namespace Lesson_1_Lib
{
    public static class Task_9
    {
        public static void Run()
        {
            Console.WriteLine("Даны целые положительные числа N и K\nИспользуя только операции сложения и вычитания,\n" +
                "найти частное от деления нацело N на K, а также остаток от этого деления.\n");
            int n = ConsoleIO_Lib.ConsolIO.GetNumber("делимое");
            int k = ConsoleIO_Lib.ConsolIO.GetNumber("делитель");
            int quot, rem;

            GetQuotientAndRemainder(n, k, out quot, out rem);
            Console.WriteLine($"Результат деления: {n} / {k} = {quot} остаток {rem}");
            ConsoleIO_Lib.ConsolIO.PauseClear();
        }

        static void GetQuotientAndRemainder(int divident, int divider, out int quot, out int rem)
        {
            quot = 0;
            while (divident > divider)
            {
                divident -= divider;
                quot++;
            }
            rem = divident;
        }
    }
}

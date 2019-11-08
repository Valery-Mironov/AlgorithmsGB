/* Антон Алиев
 * Алгоритмы, урок 1, задание 9
 * 
 * Даны целые положительные числа N и K. Используя только операции сложения и вычитания, 
 * найти частное от деления нацело N на K, а также остаток от этого деления.
 */

using System;

namespace Task_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = GetNumber();
            int k = GetNumber();
            int quot, rem;

            GetQuotientAndRemainder(n, k, out quot, out rem);
            Console.WriteLine($"Результат деления: {n} / {k} = {quot} остаток {rem}");
            Console.ReadKey();
        }

        static void GetQuotientAndRemainder(int divident, int divider, out int quot, out int rem)
        {
            quot = 0;
            while(divident > divider)
            {
                divident -= divider;
                quot++;
            }
            rem = divident;
        }

        /// <summary>
        /// Циклично запрашивает из консоли целое число
        /// </summary>
        /// <param name="msg"></param>
        /// <returns></returns>
        static int GetNumber(string msg = "")
        {
            string str;
            int result;
            bool isCorrect = false;
            do
            {
                Console.WriteLine($"Введите {msg} целое число:");
                str = Console.ReadLine();
                isCorrect = int.TryParse(str, out result);
                if (!isCorrect)
                {
                    Console.WriteLine($"Ошибка ввода!\n{str} - не соответствует условию...\n Повторите ввод:");
                }
            }
            while (!isCorrect);
            return result;
        }
    }
}

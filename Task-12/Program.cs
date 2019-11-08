/* Антон Алиев
 * Алгоритмы, урок 1, задание 12
 * 
 * Написать функцию нахождения максимального из трёх чисел
 */
using System;

namespace Task_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите поочередно три целых числа:");
            int a = GetNumber("первое");
            int b = GetNumber("второе");
            int c = GetNumber("третье");

            Console.WriteLine($"Максимальным из введенных чисел является {MaxNumber(a,b,c)}");
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

        /// <summary>
        /// Циклично запрашивает из консоли целое число
        /// </summary>
        /// <param name="msg"></param>
        /// <returns></returns>
        static int GetNumber(string msg)
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

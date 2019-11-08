/* Антон Алиев
 * Алгоритмы, урок 1, задание 10*
 * 
 * Дано целое число N > 0. С помощью операций деления нацело и взятия остатка от деления определить,
 * имеются ли в записи числа N нечётные цифры.
 * Если имеются, то вывести True, если нет – вывести False
 */

using System;

namespace Task_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int numb = GetNumber();
            Console.WriteLine(IsHaveOddDigit(numb));
            Console.ReadKey();
        }

        /// <summary>
        /// Циклично запрашивает из консоли целое число
        /// </summary>
        /// <param name="msg"></param>
        /// <returns></returns>
        static int GetNumber(string msg ="")
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

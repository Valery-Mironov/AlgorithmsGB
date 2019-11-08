/* Антон Алиев
 * Алгоритмы, урок 1, задание 11
 * 
 * С клавиатуры вводятся числа, пока не будет введён 0. 
 * Подсчитать среднее арифметическое всех положительных чётных чисел, оканчивающихся на 8.
 */

using System;

namespace Task_11
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine($"Введите число в диапазоне от {int.MinValue} до {int.MaxValue}\nДля расчета введите 0");

            int numb;
            double summ = 0;
            int counter = 0;
            double mean = 0;

            do
            {
                numb = GetNumber();
                if (numb > 0 && numb % 10 == 8)
                {
                    counter++;
                    summ += numb;
                }
            }
            while (numb != 0);

            mean = summ / counter;
            PrintResult(counter, mean);
        }

        /// <summary>
        /// Циклично запрашивает из консоли число, пока не будет введено корректное значение
        /// </summary>
        /// <returns></returns>
        static int GetNumber()
        {
            string str;
            int result;
            bool isCorrect = false;
            do
            {
                Console.WriteLine("Введите целое число:");
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
        /// Выводит результат работы программы в консоль
        /// </summary>
        /// <param name="counter">количество удовлетворяющих условию чисел</param>
        /// <param name="mean">среднее арифметическое</param>
        static void PrintResult(int counter, double mean)
        {
            Console.WriteLine($"Среднее арифметическое из {counter} введенных положительных чисел оканчивающихся на 8 = {mean :f3}");
            Console.ReadKey();
        }
    }
}

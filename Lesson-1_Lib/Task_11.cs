/* Антон Алиев
 * Алгоритмы, урок 1, задание 11
 * 
 * С клавиатуры вводятся числа, пока не будет введён 0. 
 * Подсчитать среднее арифметическое всех положительных чётных чисел, оканчивающихся на 8.
 */

using System;

namespace Lesson_1_Lib
{
    public static class Task_11
    {
        public static void Run()
        {
            Console.WriteLine("С клавиатуры вводятся числа, пока не будет введён 0.\n" +
                "Подсчитать среднее арифметическое всех положительных чётных чисел, оканчивающихся на 8\n");

            int numb;
            double summ = 0;
            int counter = 0;
            double mean = 0;
            
            do
            {
                numb = ConsoleIO_Lib.ConsolIO.GetNumber($"число в диапазоне от {int.MinValue} до {int.MaxValue}\nДля расчета введите 0");
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
        /// Выводит результат работы программы в консоль
        /// </summary>
        /// <param name="counter">количество удовлетворяющих условию чисел</param>
        /// <param name="mean">среднее арифметическое</param>
        static void PrintResult(int counter, double mean)
        {
            Console.WriteLine($"Среднее арифметическое из {counter} введенных положительных чисел оканчивающихся на 8 = {mean:f3}");
            ConsoleIO_Lib.ConsolIO.PauseClear();
        }
    }
}

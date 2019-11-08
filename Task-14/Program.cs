using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace ConsoleApp3
{
    class Program
    {
        static decimal start = 6;
        static decimal sqrStart;
        static int capasity;
        static decimal next;
        static int capasityNext;
        static decimal coulpe;
        static int capasityCouple;
        static SortedSet<decimal> list = new SortedSet<decimal>() { 1, 5, 6 };
        static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();
            decimal stop = 10000000000;
            Console.WriteLine("Диапазон расчета автоморфных чисел от 1 до {0:### ### ### ###}", 100000000000);
            stopwatch.Start();

            do
            {
                sqrStart = Sqr(start);
                capasity = Capasity(start);
                next = GetNextNumb(start);
                coulpe = GetCouple(next);

                list.Add(next);
                list.Add(coulpe);

                start = next;
            }
            while (next < stop);
            foreach (var item in list)
            {
                Console.WriteLine("{0,15:### ### ### ###}", item);
            }
            stopwatch.Stop();
            Console.WriteLine();
            Console.WriteLine($"Затрачено: {stopwatch.Elapsed.TotalSeconds} секунд");
        }

        /// <summary>
        /// Возвращает пару к автоморфному числу в той же разрядности
        /// </summary>
        /// <param name="numb"></param>
        /// <returns></returns>
        static decimal GetCouple(decimal numb)
        {
            capasityNext = Capasity(numb);
            capasityCouple = Capasity(coulpe);
            decimal second;

            if (capasityNext - capasityCouple > 1)
            {
                second = Convert.ToDecimal(Math.Pow(10, Capasity(numb / 10))) + 1 - start;
            }
            else
            {
                second = Convert.ToDecimal(Math.Pow(10, capasityNext)) + 1 - numb;
            }
            return second;
        }

        /// <summary>
        /// Получает следующее автоморфное число с 6 на конце
        /// </summary>
        /// <param name="prev"></param>
        /// <returns></returns>
        static decimal GetNextNumb(decimal prev)
        {
            int temp = (int)(sqrStart / Convert.ToDecimal(Math.Pow(10, capasity))) % 10;
            decimal result = (10 - temp) * 10 * Convert.ToDecimal(Math.Pow(10, capasity - 1)) + prev;

            return result; ;
        }

        /// <summary>
        /// Возвращает разрядность числа в десятичной системе счисления
        /// </summary>
        /// <param name="numb"></param>
        /// <returns></returns>
        static int Capasity(decimal numb)
        {
            int result = (int)Math.Log10((double)numb) + 1;
            return result;
        }

        /// <summary>
        /// Возвращает квадрат числа
        /// </summary>
        /// <param name="numb"></param>
        /// <returns></returns>
        static decimal Sqr(decimal numb)
        {
            return Convert.ToDecimal(Math.Pow((double)numb, 2));
        }

        /// <summary>
        /// Получает из консоли верхнюю границу диапазона
        /// </summary>
        /// <returns></returns>
        static int GetNaturalNumber()
        {
            int n;
            bool flag = false;
            do
            {
                Console.Write("Введите натуральное число: ");
                if (!int.TryParse(Console.ReadLine(), out n) || n < 0)
                {
                    Console.WriteLine("\nОшибка!\nДля повторного вввода нажмите Enter...");
                    Console.ReadLine();
                    Console.Clear();
                }
                else flag = true;
            }
            while (!flag);
            return n;
        }
    }
}

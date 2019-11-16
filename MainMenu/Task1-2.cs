/* Антон Алиев
 * Алгоритмы, домашнее задание к уроку 3. 
 * 
 * Задание 1
 * Попробовать оптимизировать пузырьковую сортировку. Сравнить количество операций сравнения оптимизированной и неоптимизированной программы. 
 * Написать функции сортировки, которые возвращают количество операций.
 * 
 * Задание 2*
 * Реализовать шейкерную сортировку
 */

using System;

namespace Lesson_3_Lib
{
    public static class Task1_2
    {
        static string msg1 = "Задание 1\nПопробовать оптимизировать пузырьковую сортировку.\n" +
            "Сравнить количество операций сравнения оптимизированной и неоптимизированной программы.\n" +
            "Написать функции сортировки, которые возвращают количество операций.";
        static string msg2 = "Задание 2*\nРаелизовать шейкерную сортировку";
        
        static int testArrLength = 40;
        static int[] arr = ArraySort.RandomArray(testArrLength);

        public static void Task1()
        {
            int bubbleOperat;
            int optBubbleOperat;

            Console.Clear();
            Console.WriteLine(msg1);
            Console.WriteLine("нажмите любую клавишу...");
            Console.ReadKey(true);

            Console.WriteLine("\nИсходный массив:");
            PrintArr(arr);
            Console.WriteLine();

            Console.WriteLine("\nСортировка пузырьком:");
            PrintArr(ArraySort.BubbleSort((int[])arr.Clone(), out bubbleOperat));
            Console.WriteLine($"\nПроизведено {bubbleOperat} операций");

            Console.WriteLine("\nСортировка улучшеным пузырьком:");
            PrintArr(ArraySort.OptimizedBubbleSort((int[])arr.Clone(), out optBubbleOperat));
            Console.WriteLine($"\nПроизведено {optBubbleOperat} операций\n");

            ConsoleIO_Lib.ConsolIO.PauseClear();
        }

        public static void Task2()
        {
            int operations;
            Console.Clear();
            Console.WriteLine(msg2);
            Console.WriteLine("нажмите любую клавишу...");

            Console.WriteLine("\nИсходный массив:");
            PrintArr(arr);
            Console.WriteLine();

            Console.WriteLine("\nШейкерная сортировка:");
            PrintArr(ArraySort.ShakerSort((int[])arr.Clone(), out operations));
            Console.WriteLine($"\nПроизведено {operations} операций\n");

            ConsoleIO_Lib.ConsolIO.PauseClear();
        }

        /// <summary>
        /// Выводит в консоль массив
        /// </summary>
        /// <param name="arr"></param>
        static void PrintArr(int[] arr)
        {
            foreach (int item in arr)
            {
                Console.Write($"{item} ");
            }
        }
    }
}

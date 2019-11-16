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
    public static class Tasks
    {
        static string msg1 = "Задание 1\nПопробовать оптимизировать пузырьковую сортировку.\n" +
            "Сравнить количество операций сравнения оптимизированной и неоптимизированной программы.\n" +
            "Написать функции сортировки, которые возвращают количество операций.";

        static string msg2 = "Задание 2*\nРаелизовать шейкерную сортировку";

        static string msg3 = "Задание 3\nРеализовать бинарный алгоритм поиска в виде функции, которой передаётся отсортированный массив.\n" +
            "Функция возвращает индекс найденного элемента или –1, если элемент не найден.";

        static int testArrLength = 40;
        static int[] arr;

        static int bubbleOperat;
        static int optBubbleOperat;
        static int shakeOperat;

        public static void Task1()
        {
            arr = Array.RandomArray(testArrLength);

            Greeting(msg1);

            PrintArr(arr, "\nИсходный массив:");
            
            PrintArr(Array.BubbleSort((int[])arr.Clone(), out bubbleOperat), "\nСортировка пузырьком:");
            Console.WriteLine($"\nПроизведено {bubbleOperat} операций");

            PrintArr(Array.OptimizedBubbleSort((int[])arr.Clone(), out optBubbleOperat), "\nСортировка улучшеным пузырьком:");
            Console.WriteLine($"\nПроизведено {optBubbleOperat} операций\n");

            ConsoleIO_Lib.ConsolIO.PauseClear();
        }

        public static void Task2()
        {
            arr = Array.RandomArray(testArrLength);
            Greeting(msg2);

            PrintArr(arr, "Исходный массив");
            
            PrintArr(Array.ShakerSort((int[])arr.Clone(), out shakeOperat), "\nШейкерная сортировка");
            Console.WriteLine($"\nПроизведено {shakeOperat} операций\n");

            ConsoleIO_Lib.ConsolIO.PauseClear();
        }

        public static void Task3()
        {
            arr = Array.RandomArray(testArrLength, 0, 151);
            int findNumb;
            int[] sortedArr = Array.ShakerSort((int[])arr.Clone(), out shakeOperat);
            Greeting(msg3);

            PrintArr(sortedArr, "Отсортированный массив:");

            Console.WriteLine("\nВведите число для поиска:");
            findNumb = ConsoleIO_Lib.ConsolIO.GetNumber();
            Console.WriteLine($"\nИндекс искомого числа: {Array.FindIndex(sortedArr,findNumb)}"); 
            Console.ReadKey();
        }

        /// <summary>
        /// Чистит консоль и выводит условие задачи
        /// </summary>
        /// <param name="msg"></param>
        static void Greeting(string msg)
        {
            Console.Clear();
            Console.WriteLine(msg);
            Console.WriteLine("Нажмите любую клавишу...");
            Console.ReadKey(true);
        }

        /// <summary>
        /// Выводит в консоль массив
        /// </summary>
        /// <param name="arr"></param>
        static void PrintArr(int[] arr, string msg)
        {
            Console.WriteLine($"\n{msg}");
            foreach (int item in arr)
            {
                Console.Write($"{item} ");
            }
        }
    }
}

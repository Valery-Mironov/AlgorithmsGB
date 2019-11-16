/* Антон Алиев
 * Алгоритмы, домашнее задание к уроку 3. 
 * 
 * Задание 1
 * Попробовать оптимизировать пузырьковую сортировку. Сравнить количество операций сравнения оптимизированной и неоптимизированной программы. 
 * Написать функции сортировки, которые возвращают количество операций.
 */

using System;

namespace Lesson_3_Lib
{
    public static class Task1
    {
        static string msg = "Задание 1\nПопробовать оптимизировать пузырьковую сортировку.\n" +
            "Сравнить количество операций сравнения оптимизированной и неоптимизированной программы.\n" +
            "Написать функции сортировки, которые возвращают количество операций.";

        static int testArrLength = 1000;

        public static void Run()
        {
            Console.Clear();
            Console.WriteLine(msg);
            Console.WriteLine("нажмите любую клавишу...");
            Console.ReadKey(true);

            ArraySort.TestSort(testArrLength);
            Console.WriteLine($"\nМассив из {testArrLength} элементов отсортирован:");
            Console.WriteLine($"Методом пузырка за \t\t{ArraySort.bubbleOperat} операций");
            Console.WriteLine($"Улучшенным методом пузырка за \t{ArraySort.optBubbleOperat} операций");
            ConsoleIO_Lib.ConsolIO.PauseClear();
        }
    }
}

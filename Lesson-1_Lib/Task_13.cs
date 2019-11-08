/* Антон Алиев
 * Алгоритмы, урок 1, задание 13*
 * 
 * Написать функцию, генерирующую случайное число от 1 до 100:
 * a) С использованием стандартной функции rand().
 * b) Без использования стандартной функции rand().
 */
using System;

namespace Lesson_1_Lib
{
    public static class Task_13
    {
        public static void Run()
        {
            Console.WriteLine("Написать функцию, генерирующую случайное число от 1 до 100:\n" +
                "*a) С использованием стандартной функции rand()\n" +
                "*b) Без использования стандартной функции rand()\n");
            Console.WriteLine("Для демонстрации генератора псевдослучайных чисел\nНажмите любую клавишу...");
            Console.ReadKey(true);
            Random rnd = new Random();
            MyRandom myRnd = new MyRandom();
            ConsoleKeyInfo key;
            do
            {
                Console.WriteLine($"Случайное число с использованием встроенного ГПС: {rnd.Next(1, 101)}");
                Console.WriteLine($"Случайное число без использования встроенного ГПС: {myRnd.Next(1, 101)}");
                Console.WriteLine("Для выхода нажмите \"Esc\", для повтора нажмите любую клавишу...\n");
                key = Console.ReadKey(true);
            }
            while (key.Key != ConsoleKey.Escape);
            Console.Clear();
        }
    }
}

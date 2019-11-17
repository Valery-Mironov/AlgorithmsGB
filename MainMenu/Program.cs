/* Антон Алиев
 * Алгоритмы, домашнее задание к уроку 3
 * Основное консольное меню
 */

using Lesson_3_Lib;
using System;

namespace MainMenu
{
    public static class Program
    {
        static Tasks tasks = new Tasks(5,100);
        static void Main(string[] args)
        {
            int numb;
            do
            {
				string[] tasksMsg = new string[] 
				{
                    "1. Попробовать оптимизировать пузырьковую сортировку.\n" +
                    "Сравнить количество операций сравнения оптимизированной и неоптимизированной программы.\n" +
                    "Написать функции сортировки, которые возвращают количество операций.",
                    "2. *Реализовать шейкерную сортировку.",
                    "3. Реализовать бинарный алгоритм поиска в виде функции, которой передаётся отсортированный массив.\n" +
                    "Функция возвращает индекс найденного элемента или –1, если элемент не найден.",
                    "4. *Подсчитать количество операций для каждой из сортировок и сравнить его с асимптотической сложностью алгоритма."
                };
				
				Console.Clear();
				Console.WriteLine("Антон Алиев\tДомашнее задание к уроку 3\tКурс Алгоритмы GB");

				foreach(string msg in tasksMsg) Console.WriteLine(msg + "\n");

                Console.WriteLine($"Для демонстрации решения задачи - ввдете номер задачи и нажмите \"Enter\"\nДля выхода введите 0\n");

                numb = ConsoleIO_Lib.ConsolIO.GetNumber();
				switch (numb)
                {
                    case 0: break;
                    case 1:
                        tasks.Task1();
                        break;
                    case 2:
                        tasks.Task2();
                        break;
                    case 3:
                        tasks.Task3();
                        break;
                    case 4:
                        tasks.Task4();
                        break;
                    default: { Console.WriteLine($"В решении нет задачи с номером {numb}..."); Console.ReadKey(); continue; }
                }
            }
            while (numb !=0);
        }
    }
}

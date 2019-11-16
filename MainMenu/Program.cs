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
        //public static TestArray testArray;
        static void Main(string[] args)
        {
            //testArray = new TestArray();
            int numb;
            do
            {
				string[] tasks = new string[] 
				{
                    "1. Попробовать оптимизировать пузырьковую сортировку. Сравнить количество операций сравнения оптимизированной и неоптимизированной программы. " +
                        "Написать функции сортировки, которые возвращают количество операций.",
                    "2. *Реализовать шейкерную сортировку.",
                    "3. Реализовать бинарный алгоритм поиска в виде функции, которой передаётся отсортированный массив. " +
                        "Функция возвращает индекс найденного элемента или –1, если элемент не найден.",
                    "4. Сгенерировать новый массив"
                };
				
				Console.Clear();
				Console.WriteLine("Антон Алиев\tДомашнее задание к уроку 3\tКурс Алгоритмы GB");
				Console.WriteLine($"Для демонстрации решения задачи - ввдете номер задачи и нажмите \"Enter\"\nДля выхода введите 0\n");

				foreach(string msg in tasks)
					Console.WriteLine(msg + "\n");
				
                numb = ConsoleIO_Lib.ConsolIO.GetNumber();
				switch (numb)
                {
                    case 1:
                        Task1_2.Task1();
                        break;
                    case 2:
                        Task1_2.Task2();
                        break;
                    //case 3:
                    //    Task3.Run();
                    //    break;
                    //case 4:
                    //    Lesson_3_Lib.ArreyClass.Run();
                    //    break;
                    default: { Console.WriteLine($"В решении нет задачи с номером {numb}"); continue; }
                }
            }
            while (numb !=0);
        }
    }
}

/* Антон Алиев
 * Алгоритмы, домашнее задание к уроку 1
 * 
 */
using System;

namespace Lesson_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numb;
            Console.WriteLine("Антон Алиев\tДомашнее задание к уроку 1\tКурс Алгоритмы GB\n");
            do
            {
                for (int i = 9; i <= 14; i++)
                {
                    Console.WriteLine($"Для демонстрации задачи №{i:D2} ввдете {i:D2} и нажмите \"Enter\"");
                }
                Console.WriteLine("\nДля выхода введите 0");
                numb = ConsoleIO_Lib.ConsolIO.GetNumber("номер задачи:");
                switch(numb)
                {
                    case 9:
                        Lesson_1_Lib.Task_9.Run();
                        break;
                    case 10:
                        Lesson_1_Lib.Task_10.Run();
                        break;
                    case 11:
                        Lesson_1_Lib.Task_11.Run();
                        break;
                    case 12:
                        Lesson_1_Lib.Task_12.Run();
                        break;
                    case 13:
                        Lesson_1_Lib.Task_13.Run();
                        break;
                    case 14:
                        Lesson_1_Lib.Task_14.Run();
                        break;
                    default: { Console.WriteLine($"В решении нет задачи с номером {numb}"); continue; }
                }
            }
            while (numb !=0);
        }
    }
}

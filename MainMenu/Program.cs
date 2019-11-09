/* Антон Алиев
 * Алгоритмы, домашнее задание к уроку 2
 */

using System;

namespace MainMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            int numb;
            Console.WriteLine("Антон Алиев\tДомашнее задание к уроку 2\tКурс Алгоритмы GB\n");
            do
            {
                for (int i = 1; i <= 3; i++)
                {
                    Console.WriteLine($"Для демонстрации задачи №{i} ввдете {i} и нажмите \"Enter\"");
                }
                Console.WriteLine("\nДля выхода введите 0");
                numb = ConsoleIO_Lib.ConsolIO.GetNumber("номер задачи:");
                switch (numb)
                {
                    case 1:
                        //Lesson_1_Lib.Task_9.Run();
                        break;
                    case 2:
                        //Lesson_1_Lib.Task_10.Run();
                        break;
                    case 3:
                        Lesson_2_Lib.Task3.Run();
                        break;
                    case 4:
                        //Lesson_1_Lib.Task_12.Run();
                        break;
                    case 5:
                        //Lesson_1_Lib.Task_13.Run();
                        break;
                    case 6:
                        //Lesson_1_Lib.Task_14.Run();
                        break;
                    default: { Console.WriteLine($"В решении нет задачи с номером {numb}"); continue; }
                }
            }
            while (numb != 0);
        }
    }
}

/* Антон Алиев
 * Алгоритмы, домашнее задание к уроку 3
 * Основное консольное меню
 */

using System;

namespace MainMenu
{
    class Program
    {
        static void Main(string[] args)
        {
			int numb;
            do
            {
				string[] tasks = new string[] 
				{
					
				};
				
				Console.Clear();
				Console.WriteLine("Антон Алиев\tДомашнее задание к уроку 3\tКурс Алгоритмы GB");
				Console.WriteLine($"Для демонстрации решения задачи - ввдете номер задачи и нажмите \"Enter\"\n");

				foreach(string msg in tasks)
					Console.WriteLine(msg + "\n");
				
                numb = ConsoleIO_Lib.ConsolIO.GetNumber("Для выхода введите 0");
				switch (numb)
                {
                    case 1:
                        //Lesson_2_Lib.Task1.Run();
                        break;
                    case 2:
                        //Lesson_2_Lib.Task2.Run();
                        break;
                    case 3:
                        //Lesson_2_Lib.Task3.Run();
                        break;
                    default: { Console.WriteLine($"В решении нет задачи с номером {numb}"); continue; }
                }
            }
            while (numb !=0);
        }
    }
}

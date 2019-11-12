/* Антон Алиев
 * Алгоритмы,  урок 3, задание 3**
 * 
 * Исполнитель «Калькулятор» преобразует целое число, записанное на экране. У исполнителя две команды, каждой присвоен номер:
 *    1. Прибавь 1.
 *    2. Умножь на 2.
 * Первая команда увеличивает число на экране на 1, вторая увеличивает его в 2 раза.
 * Определить, сколько существует программ, которые преобразуют число 3 в число 20:
 *    а. С использованием массива.
 *    b. *С использованием рекурсии.
 */

using Lesson_2_Lib.Task_3;
using System;
using static ConsoleIO_Lib.ConsolIO;

namespace Lesson_2_Lib
{
	public class Task3
	{
		public static void Run()
		{
			bool exitFlag = false;
			int select;
			do
			{
				Console.Clear();
				Console.WriteLine("Исполнитель «Калькулятор» преобразует целое число, записанное на экране." +
					"\nУ исполнителя две команды, каждой присвоен номер:\n" +
					"1.Прибавь 1\n2.Умножь на 2\nПервая команда увеличивает число на экране на 1,\n" +
					"вторая увеличивает его в 2 раза.\n" +
					"Определить, сколько существует программ, которые преобразуют число 3 в число 20:\n" +
					"а) С использованием массива\nb) С использованием рекурсии *");
				
				Console.WriteLine("\nВыберите дальнейшее действие:\n0 - Выйти\n1 - Сыграть в игру\n2 - Выполнить задание");
				select = GetNumber();

				switch(select)
				{
					case 0:
						exitFlag = true;
						Console.Clear();
						break;
					case 1: 
						ConsoleGame game = new ConsoleGame(GetNumber("Введите начальное число: "), GetNumber("Введите конечное число: ")); 
						game.StartGame();
						break;
					case 2:
						CalculateTask3();
						break;
					default: 
						Console.WriteLine($"В текущем меню нет пункта {select}\nДля повтора нажмите любую клавишу...");
						Console.ReadKey();
						break;
				}
			}
			while (!exitFlag);
		}

		static void CalculateTask3()
		{
			Calculator calc = new Calculator(3, 20);
			int recursMethod = 0;
			RecursCalc(calc.Start);
			
			Console.WriteLine($"\nНайдено {recursMethod} возможных вариантов решения рекурсивным методом");
			Console.WriteLine($"Найдено {"(в разработке)"} взможных вариантов с использованием массива");
			Console.ReadKey();

			void RecursCalc(int temp)
			{
				if (temp == calc.Finish)
				{
					recursMethod++;
					return;
				}
				if (temp > calc.Finish)
					return;
				else
				{
					if (temp * 2 <= calc.Finish) RecursCalc(temp * 2);
					RecursCalc(temp + 1);
					return;
				}
			}
		}
	}
}

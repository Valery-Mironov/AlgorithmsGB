/* Антон Алиев
 * Алгоритмы,  урок 2, задание 1
 * 
 * Реализовать функцию перевода чисел из десятичной системы в двоичную, используя рекурсию.
 */

using Lesson_2_Lib.Task_2;
using System;
using static ConsoleIO_Lib.ConsolIO;

namespace Lesson_2_Lib
{
	public class Task1
    {
        public static void Run()
        {
			ConsoleKeyInfo key;
			do
			{
				Console.Clear();

				Console.WriteLine("Задание 1\nРеализовать функцию перевода чисел из десятичной системы в двоичную, используя рекурсию.");
				int decInt = GetNumber($"Введите целое число в десятичной системе: от {int.MinValue} до {int.MaxValue}");
				bool[] binInt = MyConvert.IntToBin(decInt);

				PrintResult(decInt, binInt);
				Console.WriteLine("\nДля повтора нажмите любую клавишу...\nДля выхода нажмите \"Esc\"");
				key = Console.ReadKey(true);
			}
			while (key.Key != ConsoleKey.Escape);
        }

		/// <summary>
		/// Выводит в консоль число в десятичной и в двоичной системе
		/// </summary>
		/// <param name="dec">десятичное представление</param>
		/// <param name="bin">двоичное число</param>
		static void PrintResult(int dec, bool[] bin)
		{
			bool flag = false;
			Console.Write($"{dec} (Dec) = ");
			for (int i = 0; i < bin.Length / 4; i++)
			{
				for (int j = 0; j < 4; j++)
				{
					//Console.Write("*");
					if (!flag && !bin[i * 4 + j]) continue;
					else flag = true;
				}
				if (flag)
				{
					for (int k = 0; k < 4; k++)
					{
						if (bin[i*4+k]) Console.Write(1);
						else Console.Write(0);
					}
					Console.Write(" ");
				}
			}
			if (!flag) Console.Write(0);
			Console.Write("(Bin)");
		}
    }
}

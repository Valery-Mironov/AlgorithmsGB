/* Антон Алиев
 * Алгоритмы,  урок 2, задание 2
 * 
 * Реализовать функцию возведения числа a в степень b:
 * a) Без рекурсии.
 * b) Рекурсивно.
 * c) *Рекурсивно, используя свойство чётности степени.
 */

using System;
using static ConsoleIO_Lib.ConsolIO;

namespace Lesson_2_Lib
{
	public class Task2
    {
        public static void Run()
        {
            Console.WriteLine("Задание 2\nРеализовать функцию возведения числа a в степень b:\n" +
                "1) Без рекурсии\n2)Рекурсивно\n3)* Рекурсивно, используя свойство чётности степени");
			
			double number = GetNumber("Введите основание степени:");
			int power = GetNumber("Введите показатель степени:");
			Console.WriteLine($"Без рекурсии:\t\t{number,8}^{power}={Pow(number,power)}");
			Console.WriteLine($"С рекурсией:\t\t{number,8}^{power}={RecPow(number, power)}");
			Console.WriteLine($"С чет.рекурсией:\t{number,8}^{power}={RecPowPary(number, power)}");
			Console.ReadKey();

		}

		/// <summary>
		/// Возведение числа в степень через цикл
		/// </summary>
		/// <param name="numb">основание степени</param>
		/// <param name="pow">показатель степени</param>
		/// <returns>numb^pow</returns>
		static double Pow(double numb, int pow)
		{
			double result = numb;
			if (numb == 0) return 0;
			else if (numb == 1 || pow == 0) return 1;

			if (pow > 0)
			{
				while (pow > 1)
				{
					result *= numb;
					pow--;
				}
			}
			else
			{
				while (pow < -1)
				{
					result *= numb;
					pow++;
				}
				return 1 / result;
			}
			return result;
		}

		/// <summary>
		/// Рекурсивный метод возведения в степень
		/// </summary>
		/// <param name="numb">основание степени</param>
		/// <param name="pow">показатель степени</param>
		/// <returns>numb^pow</returns>
		static double RecPow(double numb, int pow)
		{
			if (numb == 0) return 0;
			if (numb == 1 || pow == 0) return 1;
			if (pow > 0) return RecPow(numb , --pow) * numb;
			if (pow < 0) return 1/ (RecPow(numb, Math.Abs(++pow)) * numb);
			return numb;
		}

		/// <summary>
		/// Рекурсивное возведение в степень с учетом четности
		/// </summary>
		/// <param name="numb">основание степени</param>
		/// <param name="pow">показатель степени</param>
		/// <returns>numb^pow</returns>
		static double RecPowPary(double numb, int pow)
		{
			if (numb == 0) return 0;
			if (numb == 1 || pow == 0) return 1;
			if (pow == -1) return 1 / numb;
			if (pow > 2 && pow % 2 == 0) return RecPowPary(RecPowPary(numb, pow / 2), 2);
			return RecPowPary(numb, pow / 2) * RecPow(numb, pow - pow / 2);
		}
	}
}
